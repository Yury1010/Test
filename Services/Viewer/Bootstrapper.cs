using ABCS.Test.Infrastructure;
using ABCS.Test.Module.Communication;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using Prism.Unity.Extension;
using Unity;

namespace ABCS.Test.Web.Viewer
{
    internal sealed class Bootstrapper(IUnityContainer _container) : UnityBootstrapper
    {
        #region Методы
        protected override IContainerExtension CreateContainerExtension()
        {
            return new UnityContainerExtension(_container);
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            CommunicationModule.Location = Location.Tester;

            _ = moduleCatalog
                .AddModule<CommunicationModule>();
        }
        protected override void OnInitialized()
        {
        }
        #endregion
    }
}
