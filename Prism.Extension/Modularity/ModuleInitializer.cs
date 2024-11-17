using Prism.Ioc;
using Prism.Modularity;
using Prism.Properties;
using System;
using System.Globalization;

namespace Prism.Unity.Modularity
{
    public class ModuleInitializer : IModuleInitializer
    {
        private readonly IContainerExtension _containerExtension;

        public ModuleInitializer(IContainerExtension containerExtension) => _containerExtension = containerExtension ?? throw new ArgumentNullException(nameof(containerExtension));

        public void Initialize(IModuleInfo moduleInfo)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            IModule imodule = (IModule)null;
            try
            {
                imodule = CreateModule(moduleInfo);
                if (imodule == null)
                    return;
                imodule.RegisterTypes(_containerExtension);
                imodule.OnInitialized(_containerExtension);
            }
            catch (Exception ex)
            {
                HandleModuleInitializationError(moduleInfo, ((object)imodule)?.GetType().Assembly.FullName, ex);
            }
        }

        public virtual void HandleModuleInitializationError(
          IModuleInfo moduleInfo,
          string assemblyName,
          Exception exception)
        {
            if (moduleInfo == null)
                throw new ArgumentNullException(nameof(moduleInfo));
            if (exception == null)
                throw new ArgumentNullException(nameof(exception));
            throw !(exception is ModuleInitializeException) ? (string.IsNullOrEmpty(assemblyName) ? (Exception)new ModuleInitializeException(moduleInfo.ModuleName, exception.Message, exception) : (Exception)new ModuleInitializeException(moduleInfo.ModuleName, assemblyName, exception.Message, exception)) : exception;
        }

        protected virtual IModule CreateModule(IModuleInfo moduleInfo) => moduleInfo != null ? CreateModule(moduleInfo.ModuleType) : throw new ArgumentNullException(nameof(moduleInfo));

        protected virtual IModule CreateModule(string typeName)
        {
            Type type = Type.GetType(typeName);
            return !(type == (Type)null) ? (IModule)_containerExtension.Resolve(type) : throw new ModuleInitializeException(string.Format((IFormatProvider)CultureInfo.CurrentCulture, Resources.FailedToGetType, (object)typeName));
        }
    }
}
