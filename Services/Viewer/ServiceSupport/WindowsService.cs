using System;
using System.Threading;
using System.Threading.Tasks;
using ABCS.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Prism.Events;
using Prism.Unity;
using Unity;
using Unity.Microsoft.DependencyInjection;

namespace ABCS.ServiceSupport
{
    public class WindowsService : BackgroundService
    {
        private readonly IUnityContainer _container;
        private readonly ILogger _logger;

        public WindowsService(ILogger<WindowsService> logger, IUnityContainer container)
        {
            _logger = logger;
            _container = container;
        }

        public static void Initialize<T>(string[] args, string sourceName)
        {
            Host.CreateDefaultBuilder(args).UseUnityServiceProvider().ConfigureLogging(logging => logging.AddEventLog(eventLogSettings => eventLogSettings.SourceName = sourceName)).ConfigureContainer<IUnityContainer>(c => c.RegisterInstance((UnityBootstrapper)Activator.CreateInstance(typeof(T), c))).ConfigureServices((hostContext, services) => services.AddHostedService<WindowsService>()).UseWindowsService().Build().Run();
        }

        public override async Task StartAsync(CancellationToken cancellationToken)
        {
            await Task.Run(() => _container.Resolve<UnityBootstrapper>().Run(), cancellationToken);
            await base.StartAsync(cancellationToken).ConfigureAwait(false);
            _logger.LogInformation("Initialization is completed.");
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken) => await Task.Run(() => _container.Resolve<IEventAggregator>().GetEvent<ServiceStartedEvent>().Publish());

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Stopping service..");
            await Task.Run(() => _container.Resolve<IEventAggregator>().GetEvent<ServiceShuttingDownEvent>().Publish(), cancellationToken);
            await base.StopAsync(cancellationToken);
        }
    }
}
