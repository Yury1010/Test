//using ABCS.Logging;
using ABCS.ServiceSupport;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
//using Microsoft.Internal.Extensions.Hosting;
using System;
//using System.IO;
using System.Reflection;
using Unity.Microsoft.DependencyInjection;

namespace Microsoft.Extensions.Hosting
{
    public static class WindowsWebServiceSupport
    {
        private const string _configureMethodName = "Configure";

        //public static void Initialize<TStartup>(string[] args) where TStartup : class => Host.CreateDefaultBuilder(args).UseUnityServiceProvider()/*.ConfigureLogging((hostingContext, builder) => builder.AddLogging())*/.UseWindowsService().ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<TStartup>()).Build().Run();
        public static void Initialize<TStartup>(string[] args, string sourceName) where TStartup : class
        {
            Host.CreateDefaultBuilder(args).UseUnityServiceProvider().ConfigureLogging(logging => logging.AddEventLog(eventLogSettings => eventLogSettings.SourceName = sourceName)).UseWindowsService().ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<TStartup>()).Build().Run();

            //var builder = WebApplication.CreateBuilder(args);
            //builder.Host.UseUnityServiceProvider().ConfigureLogging(logging => logging.AddEventLog(eventLogSettings => eventLogSettings.SourceName = sourceName)).UseWindowsService().UseStartup<TStartup>();
            //builder.Build().Configure<TStartup>().Run();
        }
        public static WebApplication Configure<TStartup>(this WebApplication app)
        {
            MethodInfo method = typeof(TStartup).GetMethod(_configureMethodName, new Type[] { typeof(WebApplication), typeof(IWebHostEnvironment) });
            TStartup instance;
            instance = (TStartup)(!(typeof(TStartup).GetConstructor(new Type[] { typeof(IConfiguration) }) != null) ? Activator.CreateInstance(typeof(TStartup), null) : Activator.CreateInstance(typeof(TStartup), app.Configuration));
            method?.Invoke(instance, new object[] { app, app.Environment });

            //if (configureApp == null)
            //{
            //    throw new ArgumentNullException(nameof(configureApp));
            //}

            // Light up the ISupportsStartup implementation
            //if (hostBuilder is ISupportsStartup supportsStartup)
            //{
            //    return supportsStartup.Configure(configureApp);
            //}

            //var startupAssemblyName = configureApp.GetMethodInfo().DeclaringType!.Assembly.GetName().Name!;

            //hostBuilder.UseSetting(WebHostDefaults.ApplicationKey, startupAssemblyName);

            //return hostBuilder.ConfigureServices((context, services) =>
            //{
            //    services.AddSingleton<IStartup>(sp =>
            //    {
            //        return new DelegateStartup(sp.GetRequiredService<IServiceProviderFactory<IServiceCollection>>(), (app => configureApp(app)));
            //    });
            //});
            return app;
        }

        //internal static IHostBuilder UseStartup<TStartup>(this WebApplication app) where TStartup : class
        //{
        //    TStartup startUpObj = default;
        //    hostBuilder.ConfigureServices((ctx, serviceCollection) =>
        //    {
        //        serviceCollection.AddHostedService<WindowsService>();
        //        MethodInfo method = typeof(TStartup).GetMethod(_configureServicesMethodName, new Type[] { typeof(IServiceCollection) });
        //        TStartup instance;
        //        instance = (TStartup)(!(typeof(TStartup).GetConstructor(new Type[] { typeof(IConfiguration) }) != null) ? Activator.CreateInstance(typeof(TStartup), null) : Activator.CreateInstance(typeof(TStartup), ctx.Configuration));
        //        startUpObj = instance;
        //        method?.Invoke(startUpObj, new object[] { serviceCollection });
        //    }).ConfigureContainer((Action<IUnityContainer>)(container => typeof(TStartup).GetMethod(_configureContainerMethodName, new Type[] { typeof(IUnityContainer) })?.Invoke(startUpObj, new object[] { container })));
        //    return hostBuilder;
        //}

        //public static IHostBuilder ConfigureWebHostDefaults(this IHostBuilder builder, Action<IWebHostBuilder> configure)
        //{
        //    if (configure is null)
        //    {
        //        throw new ArgumentNullException(nameof(configure));
        //    }

        //    return builder.ConfigureWebHostDefaults(configure, _ => { });
        //}
        //public static IHostBuilder ConfigureWebHostDefaults(this IHostBuilder builder, Action<IWebHostBuilder> configure, Action<WebHostBuilderOptions> configureOptions)
        //{
        //    if (configure is null)
        //    {
        //        throw new ArgumentNullException(nameof(configure));
        //    }

        //    return builder.ConfigureWebHost(webHostBuilder =>
        //    {
        //        WebHost.ConfigureWebDefaults(webHostBuilder);

        //        configure(webHostBuilder);
        //    }, configureOptions);
        //}
    }
}
