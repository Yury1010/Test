
namespace ABCS.Infrastructure
{
    /// <summary>
    /// Specifies the type of service module location
    /// </summary>
    public enum Location
    {
        /// <summary>
        /// Specifies an uninitialized Location type.
        /// </summary>
        None,
        /// <summary>
        /// Specifies Location type of service module on client side.
        /// </summary>
        Client,
        /// <summary>
        /// Specifies Location type of service module on server side.
        /// </summary>
        Server,
        /// <summary>
        /// Specifies Location type of service module on service side.
        /// </summary>
        Service,
        /// <summary>
        /// Specifies Location type of WEB service module on server side.
        /// </summary>
        WebService,
        /// <summary>
        /// Specifies Location type of WEB client module on client side.
        /// </summary>
        WebClient,
        /// <summary>
        /// Specifies Location type of service module in archiving service.
        /// </summary>
        ArchiveService,
        /// <summary>
        /// Specifies Location type of service module on user side.
        /// </summary>
        User,
        /// <summary>
        /// Specifies Location type of service module in user control.
        /// </summary>
        ControlUser,
        /// <summary>
        /// Specifies Location type of service module on updater side.
        /// </summary>
        Updater,
        /// <summary>
        /// Specifies Location type of service module on SCADA side.
        /// </summary>
        SCADA,
        /// <summary>
        /// Specifies Location type of service module on Test side.
        /// </summary>
        Test,
        /// <summary>
        /// Specifies Location type of tect client module on Test client side.
        /// </summary>
        TestClient,
        /// <summary>
        /// Specifies Location type of Test server module on Test server side.
        /// </summary>
        TestServer,
        /// <summary>
        /// Specifies Location type of report client module on Test client side.
        /// </summary>
        ReportClient,
        /// <summary>
        /// Specifies Location type of report server module on Test server side.
        /// </summary>
        ReportServer
    }
}
