using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using WebApplication12.DataRepositories;
using WebApplication12.Infrastructure;

namespace WebApplication12
{
    public class Startup
    {
        private readonly IConfiguration _configuration;                                          
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
      
        public void ConfigureServices(IServiceCollection services)
        {
            //ʹ��SQL Server���ݿ⣬ͨ��IConfiguration����ȥ��ȡ���Զ������Ƶ�StudentDBConnection��Ϊ���ǵ������ַ���
            services.AddDbContextPool<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("StudentDBConnection")));
            services.AddControllersWithViews().AddXmlSerializerFormatters();

            services.AddSingleton<IStudentRepository, StudentRepository>();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });

            //app.UseMvc();

            //app.UseMvcWithDefaultRoute();
        }
    }
}
