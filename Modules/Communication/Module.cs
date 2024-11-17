using Interop.QBXMLRP2;
using ABCS.Test.Infrastructure;
using ABCS.Test.Module.Communication.Services;
using Prism.Ioc;
using Prism.Modularity;
using Unity;

namespace ABCS.Test.Module.Communication
{
    public class CommunicationModule(IUnityContainer _container) : IModule
    {
        #region Методы
        #region Интерфейс IModule
        public void OnInitialized(IContainerProvider containerProvider)
        {
            switch (Location)
            {
                case Location.Tester:
                    break;
                default:
                    throw new ABCS.Infrastructure.InvalidLocationTypeException($"Location type {Location} not supported.");
            }
        }
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            switch (Location)
            {
                case Location.Tester:
                    _ = _container
                        .RegisterType<ICommunication, CommunicationService>()
                        .RegisterType<RequestProcessor2, RequestProcessor2Class>();
                    break;
                default:
                    throw new ABCS.Infrastructure.InvalidLocationTypeException($"Location type {Location} not supported.");
            }
        }
        #endregion
        #endregion
        #region Свойства
        public static Location Location { get; set; }
        #endregion
    }
}
