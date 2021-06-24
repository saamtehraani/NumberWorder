using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using NumberWorder.Infrastracture;

namespace NumberWorder
{
    public class Startup
    {
        public static readonly string AppName = typeof(Program).Assembly.GetName().Name;

        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            var container = new ContainerBuilder();
            container.Populate(services);

            container.RegisterModule(new ApplicationModule());

            return new AutofacServiceProvider(container.Build());
        }
    }
}
