using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Mission4TreyJackson.Models;
using Microsoft.EntityFrameworkCore;

namespace Mission4TreyJackson
{
    public class Startup
    {

 

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<movieEntryContext>(options =>
            {
                options.UseSqlite(Configuration["ConnectionStrings:movieConnection"]);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // if the page is in development mode a whole error will be shown
            if (env.IsEnvironment("Development"))
            { 
                app.UseDeveloperExceptionPage(); 
            }

          
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints => 
            {
                endpoints.MapControllerRoute(
                    name: default,
                    pattern: "{controller=subFolder}/{action=Index}/{id?}"
                    ); 
            });

        }
    }
}
