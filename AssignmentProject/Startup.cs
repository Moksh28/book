using AssignmentProject.Data;
using AssignmentProject.Models;
using AssignmentProject.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<EventContext>(options => options.UseSqlServer("Server=.;Database=EventReading;Integrated Security=True;"));
            services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<EventContext>();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();  //to see changes by refreshing page

            //uncomment below to remove client-side validation
            // .AddViewOptions(option =>
            // {
            //      option.HtmlHelperOptions.ClientValidationEnabled = false;
            // });
#endif
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ICreateRepository, CreateRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
