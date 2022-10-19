using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SiteCtor.DataBase;
using SiteCtor.DatabaseMethods;
using SiteCtor.Interfaces;
using SiteCtor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiteCtor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; set; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContext>(opts =>
            {
                opts.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
            });
            services.AddScoped<DbContext, AppDBContext>();
            services.AddTransient<IDBMethods<FirstSiteModel>, DBFirstMethods<FirstSiteModel>>();
            services.AddTransient<IDBMethods<SecondSiteModel>, DBSecondMethods<SecondSiteModel>>();
            services.AddRouting();
            services.AddControllersWithViews();
            services.AddRazorPages();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "first",
                    pattern: "{controller=First}/{action=List}/{FirstSiteModel?}");
                endpoints.MapControllerRoute(
                    name: "firstedit",
                    pattern: "{controller=First}/{action=Edit}/{firstsitemodel?}/{oldmodel?}");
                endpoints.MapControllerRoute(
                    name: "second",
                    pattern: "{controller=Second}/{action=List}");
                endpoints.MapRazorPages();
            });
        }
    }
}
