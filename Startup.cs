using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WebApplication12.DataRepositories;

namespace WebApplication12
{
    public class Startup
    {
                                               
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(a => a.EnableEndpointRouting = false).AddXmlSerializerFormatters();

            services.AddSingleton<IStudentRepository, StudentRepository>();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();
        }
    }
}
