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
using Rent_Flat_Core.Data;
using Rent_Flat_Core.Repositories;

namespace Rent_Flat_Core
{
    public class Startup
    {
        IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        //-------------------------------------
        //------------------------------------------------------
        public void ConfigureServices(IServiceCollection services)
        {
            String cadenaconexion = this.configuration.GetConnectionString("cadena");

          
            //se resuelve las dependencias con AddTransient
            services.AddTransient<IRepository, Repository>();

            services.AddTransient<RepositoryApiRent>();
            services.AddDbContext<IRentContext, RentContext>(options => options.UseSqlServer(cadenaconexion));
            services.AddMvc();
        }


        //----------------------------------------------
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //1º control de errores en desarrollo
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();//linea de control de errores
            }

            app.UseHttpsRedirection();

            //4º utilizamos los archivos estáticos
            app.UseStaticFiles();

           
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
