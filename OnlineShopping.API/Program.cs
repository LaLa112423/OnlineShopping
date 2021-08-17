
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using OnlineShopping.Dal;
using OnlineShopping.IDal;
using Autofac.Extensions.DependencyInjection;

namespace OnlineShopping.API
{
    public class Program
    {
        private static IContainer Container { set; get; }
        public static void Main(string[] args)
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<employeedate>().As<Iemployeedate>();
            Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                var demo = scope.Resolve<Iemployeedate>();
               
            }
                CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseServiceProviderFactory(new AutofacServiceProviderFactory());
    }
}
