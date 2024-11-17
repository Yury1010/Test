using Prism.Events;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity.Modularity;
using System;

namespace Prism.Unity.Helpers
{
    internal static class Helper
    {
        internal static void RegisterRequiredTypes(
          this IContainerExtension containerRegistry,
          IModuleCatalog moduleCatalog)
        {
            IContainerRegistryExtensions.RegisterInstance(containerRegistry, moduleCatalog);
            IContainerRegistryExtensions.RegisterSingleton<IModuleInitializer, ModuleInitializer>(containerRegistry);
            IContainerRegistryExtensions.RegisterSingleton<IModuleManager, ModuleManager>(containerRegistry);
            IContainerRegistryExtensions.RegisterSingleton<IEventAggregator, EventAggregator>(containerRegistry);
        }
        public static IModuleCatalog AddModule<T>(this IModuleCatalog moduleCatalog) where T : IModule
        {
            Type moduleType = typeof(T);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleType.Name,
                ModuleType = moduleType.AssemblyQualifiedName,
            });
            return moduleCatalog;
        }
    }
}

namespace Prism.Modularity
{
    public static class Helper
    {
        public static IModuleCatalog AddModule<T>(this IModuleCatalog moduleCatalog) where T : IModule
        {
            Type moduleType = typeof(T);
            moduleCatalog.AddModule(new ModuleInfo()
            {
                ModuleName = moduleType.Name,
                ModuleType = moduleType.AssemblyQualifiedName,
            });
            return moduleCatalog;
        }
    }
}
