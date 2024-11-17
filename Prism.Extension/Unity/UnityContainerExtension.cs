using Prism.Ioc;
using Prism.Ioc.Internals;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Lifetime;
using Unity.Resolution;

namespace Prism.Unity.Extension
{
    public class UnityContainerExtension :
      IContainerExtension<IUnityContainer>,
      IContainerExtension,
      IContainerProvider,
      IContainerRegistry,
      IContainerInfo
    {
        private UnityScopedProvider _currentScope;

        public IUnityContainer Instance { get; }

        public UnityContainerExtension()
          : this(new UnityContainer())
        {
        }

        public UnityContainerExtension(IUnityContainer container)
        {
            Instance = container;
            string currentContainer = "CurrentContainer";
            Instance.RegisterInstance(currentContainer, this);
            Instance.RegisterFactory(typeof(IContainerExtension), c => c.Resolve<UnityContainerExtension>(currentContainer));
            Instance.RegisterFactory(typeof(IContainerProvider), c => c.Resolve<UnityContainerExtension>(currentContainer));
            ExceptionExtensions.RegisterFrameworkExceptionType(typeof(ResolutionFailedException));
        }

        public IScopedProvider CurrentScope => _currentScope;

        public void FinalizeExtension()
        {
        }

        public IContainerRegistry RegisterInstance(Type type, object instance)
        {
            Instance.RegisterInstance(type, instance);
            return this;
        }

        public IContainerRegistry RegisterInstance(
          Type type,
          object instance,
          string name)
        {
            Instance.RegisterInstance(type, name, instance);
            return this;
        }

        public IContainerRegistry RegisterSingleton(Type from, Type to)
        {
            Instance.RegisterSingleton(from, to);
            return this;
        }

        public IContainerRegistry RegisterSingleton(Type from, Type to, string name)
        {
            Instance.RegisterSingleton(from, to, name);
            return this;
        }

        public IContainerRegistry RegisterSingleton(
          Type type,
          Func<object> factoryMethod)
        {
            Instance.RegisterFactory(type, _ => factoryMethod(), new ContainerControlledLifetimeManager());
            return this;
        }

        public IContainerRegistry RegisterSingleton(
          Type type,
          Func<IContainerProvider, object> factoryMethod)
        {
            Instance.RegisterFactory(type, c => factoryMethod(c.Resolve<IContainerProvider>()), new ContainerControlledLifetimeManager());
            return this;
        }

        public IContainerRegistry RegisterManySingleton(
          Type type,
          params Type[] serviceTypes)
        {
            Instance.RegisterSingleton(type);
            return RegisterManyInternal(type, serviceTypes);
        }

        private IContainerRegistry RegisterManyInternal(
          Type implementingType,
          Type[] serviceTypes)
        {
            if (serviceTypes == null || serviceTypes.Length == 0)
                serviceTypes = implementingType.GetInterfaces().Where(x => x != typeof(IDisposable)).ToArray();
            foreach (Type serviceType in serviceTypes)
                Instance.RegisterFactory(serviceType, c => c.Resolve(implementingType));
            return this;
        }

        public IContainerRegistry Register(Type from, Type to)
        {
            Instance.RegisterType(from, to);
            return this;
        }

        public IContainerRegistry Register(Type from, Type to, string name)
        {
            Instance.RegisterType(from, to, name);
            return this;
        }

        public IContainerRegistry Register(Type type, Func<object> factoryMethod)
        {
            Instance.RegisterFactory(type, _ => factoryMethod());
            return this;
        }

        public IContainerRegistry Register(
          Type type,
          Func<IContainerProvider, object> factoryMethod)
        {
            Instance.RegisterFactory(type, c => factoryMethod(c.Resolve<IContainerProvider>()));
            return this;
        }

        public IContainerRegistry RegisterMany(Type type, params Type[] serviceTypes)
        {
            Instance.RegisterType(type);
            return RegisterManyInternal(type, serviceTypes);
        }

        public IContainerRegistry RegisterScoped(Type from, Type to)
        {
            Instance.RegisterType(from, to, new HierarchicalLifetimeManager());
            return this;
        }

        public IContainerRegistry RegisterScoped(
          Type type,
          Func<object> factoryMethod)
        {
            Instance.RegisterFactory(type, c => factoryMethod(), new HierarchicalLifetimeManager());
            return this;
        }

        public IContainerRegistry RegisterScoped(
          Type type,
          Func<IContainerProvider, object> factoryMethod)
        {
            Instance.RegisterFactory(type, c => factoryMethod(c.Resolve<IContainerProvider>()), new HierarchicalLifetimeManager());
            return this;
        }

        public object Resolve(Type type) => Resolve(type, Array.Empty<(Type, object)>());

        public object Resolve(Type type, string name) => Resolve(type, name, Array.Empty<(Type, object)>());

        public object Resolve(Type type, params (Type Type, object Instance)[] parameters)
        {
            try
            {
                IUnityContainer container = _currentScope?.Container ?? Instance;
                DependencyOverride[] array = parameters.Select(p => new DependencyOverride(p.Type, p.Instance)).ToArray();
                if (!typeof(IEnumerable).IsAssignableFrom(type) || type.GetGenericArguments().Length == 0)
                    return container.Resolve(type, array);
                type = type.GetGenericArguments()[0];
                return container.ResolveAll(type, array);
            }
            catch (Exception ex)
            {
                throw new ContainerResolutionException(type, ex);
            }
        }

        public object Resolve(Type type, string name, params (Type Type, object Instance)[] parameters)
        {
            try
            {
                IUnityContainer unityContainer = _currentScope?.Container ?? Instance;
                if (!unityContainer.IsRegistered(type, name))
                    throw new KeyNotFoundException("No registered type " + type.Name + " with the key " + name + ".");
                DependencyOverride[] array = parameters.Select(p => new DependencyOverride(p.Type, p.Instance)).ToArray();
                return unityContainer.Resolve(type, name, array);
            }
            catch (Exception ex)
            {
                throw new ContainerResolutionException(type, name, ex);
            }
        }

        public bool IsRegistered(Type type) => Instance.IsRegistered(type);

        public bool IsRegistered(Type type, string name) => Instance.IsRegistered(type, name);

        Type IContainerInfo.GetRegistrationType(string key) => (Instance.Registrations.Where(r => key.Equals(r.Name, StringComparison.Ordinal)).FirstOrDefault() ?? Instance.Registrations.Where(r => key.Equals(r.RegisteredType.Name, StringComparison.Ordinal)).FirstOrDefault())?.MappedToType;

        Type IContainerInfo.GetRegistrationType(Type serviceType) => Instance.Registrations.Where(x => x.RegisteredType == serviceType).FirstOrDefault()?.MappedToType;

        public virtual IScopedProvider CreateScope() => CreateScopeInternal();

        protected IScopedProvider CreateScopeInternal()
        {
            _currentScope = new UnityScopedProvider(Instance.CreateChildContainer());
            return _currentScope;
        }

        private class UnityScopedProvider : IScopedProvider, IContainerProvider, IDisposable
        {
            public UnityScopedProvider(IUnityContainer container) => Container = container;

            public IUnityContainer Container { get; private set; }

            public bool IsAttached { get; set; }

            public IScopedProvider CurrentScope => this;

            public IScopedProvider CreateScope() => this;

            public void Dispose()
            {
                Container.Dispose();
                Container = null;
            }

            public object Resolve(Type type) => Resolve(type, Array.Empty<(Type, object)>());

            public object Resolve(Type type, string name) => Resolve(type, name, Array.Empty<(Type, object)>());

            public object Resolve(Type type, params (Type Type, object Instance)[] parameters)
            {
                try
                {
                    DependencyOverride[] array = parameters.Select(p => new DependencyOverride(p.Type, p.Instance)).ToArray();
                    return Container.Resolve(type, array);
                }
                catch (Exception ex)
                {
                    throw new ContainerResolutionException(type, ex);
                }
            }

            public object Resolve(
              Type type,
              string name,
              params (Type Type, object Instance)[] parameters)
            {
                try
                {
                    if (!Container.IsRegistered(type, name))
                        throw new KeyNotFoundException("No registered type " + type.Name + " with the key " + name + ".");
                    DependencyOverride[] array = parameters.Select(p => new DependencyOverride(p.Type, p.Instance)).ToArray();
                    return Container.Resolve(type, name, array);
                }
                catch (Exception ex)
                {
                    throw new ContainerResolutionException(type, name, ex);
                }
            }
        }
    }
}
