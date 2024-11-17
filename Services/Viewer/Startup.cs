using System;
using ABCS.ServiceSupport;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prism.Ioc;
using Prism.Unity;
using Unity;

namespace ABCS.Test.Web.Viewer
{
    internal sealed class Startup(IConfiguration _configuration)
    {
        #region Методы
        public void ConfigureServices(IServiceCollection services)
        {
            _ = services
                .AddControllersWithViews()
                .AddControllersAsServices();
            _ = services
                .AddHostedService<WindowsService>();
        }
        public void ConfigureContainer(IUnityContainer c)
        {
            _ = c.RegisterInstance((UnityBootstrapper)Activator.CreateInstance(typeof(Bootstrapper), c));
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                _ = app.UseDeveloperExceptionPage();
            }

            _ = app.UseHttpsRedirection();
            _ = app.UseStaticFiles();
            _ = app.UseRouting();
            _ = app.UseAuthentication();

            _ = app.UseEndpoints(endpoints =>
            {
                _ = endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        #endregion
    }
}
