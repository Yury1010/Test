using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity.Extension;
using Prism.Unity.Helpers;
using Prism.Unity.Modularity;
using System;
using Unity;

namespace Prism.Unity
{
    public abstract class UnityBootstrapper
    {
        private IModuleCatalog _moduleCatalog;
        private IContainerExtension _containerRegistry;

        public void Run()
        {
            Initialize();
            OnInitialized();
        }

        protected virtual void Initialize()
        {
            ContainerLocator.ResetContainer();
            ContainerLocator.SetContainerExtension(new Func<IContainerExtension>(this.CreateContainerExtension));
            _containerRegistry = ContainerLocator.Current;
            _moduleCatalog = CreateModuleCatalog();
            _containerRegistry.RegisterRequiredTypes(_moduleCatalog);
            RegisterTypes(_containerRegistry);
            ConfigureModuleCatalog(_moduleCatalog);
            RegisterFrameworkExceptionTypes();
            InitializeModules();
        }

        protected virtual IModuleCatalog CreateModuleCatalog() => new ModuleCatalog();

        protected abstract void ConfigureModuleCatalog(IModuleCatalog moduleCatalog);

        protected void RegisterFrameworkExceptionTypes()
        {
            ExceptionExtensions.RegisterFrameworkExceptionType(typeof(ResolutionFailedException));
        }

        protected abstract void RegisterTypes(IContainerRegistry containerRegistry);

        protected virtual void InitializeModules() => IContainerProviderExtensions.Resolve<IModuleManager>(_containerRegistry).Run();

        protected abstract void OnInitialized();

        protected virtual IContainerExtension CreateContainerExtension() => new UnityContainerExtension();

        public IUnityContainer Container => ((IContainerExtension<IUnityContainer>)_containerRegistry).Instance;
    }
}
