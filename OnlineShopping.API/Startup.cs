using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Common;
using System.Reflection;
using System.IO;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using OnlineShopping.Dal;
using OnlineShopping.IDal;

namespace OnlineShopping.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        //autofac配置
        public void ConfigureContainer(ContainerBuilder build)
        {
          
            var bllFilePath = System.IO.Path.Combine(AppContext.BaseDirectory, "OnlineShopping.Dal.dll"); //DDal.dll是依赖注入的层
            build.RegisterAssemblyTypes(Assembly.LoadFile(bllFilePath)).AsImplementedInterfaces();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            commonfiled.constr = Configuration.GetConnectionString("constr");
            services.AddControllers();
            //跨域配置
            #region
            services.AddCors(options => options.AddPolicy("cor",
         builder =>
         {
             builder.AllowAnyMethod()
                  .AllowAnyHeader()
                  .SetIsOriginAllowed(_ => true) // =AllowAnyOrigin()
                  .AllowCredentials();
         }));
            #endregion
            ////接口注入
            //services.AddSingleton<Iemployeedate, employeedate>();
            //services.AddSingleton<Imenudata, menudata>();
            //swagger配置验证
            #region
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo 
                { Title = "OnlineShopping.API",
                  Version = "v1",
                Description= "OnlineShopping.API"
                });
                //可视化文本
                #region
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath, true);
                #endregion
            });
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //swagger
            #region
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "OnlineShopping.API v1"));
            }
            #endregion
            app.UseRouting();

            app.UseAuthorization();
            //跨越配置
            #region
            app.UseCors("cor");
            #endregion
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
