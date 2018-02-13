using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Week7Demo.Data;
using Week7Demo.Models;
using Week7Demo.Services;
using Microsoft.AspNetCore.Authorization;
using Week7Demo.Models.Interfaces;

namespace Week7Demo
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddDbContext<Week7DemoContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("Week7DemoContext")));


            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddAuthorization(config =>
           {
               config.AddPolicy("Admin Only", policy => policy.RequireRole("Admin")
               .Build());

               config.AddPolicy("MinimumAge", policy => policy.Requirements.Add(new MinimumAgeRequirement()));

           }
           );

            services.AddSingleton<IAuthorizationHandler, Is18>();

            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddTransient<IArticleService, ArticleService>();

            services.AddMvc();

            services.AddDbContext<Week7DemoContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("Week7DemoContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            var t = roleManager.RoleExistsAsync(ApplicationRoles.Admin);
            t.Wait();
            if (!t.Result)
            {
                var createTask = roleManager.CreateAsync(new IdentityRole
                {
                    Name = ApplicationRoles.Admin,
                    NormalizedName = ApplicationRoles.Admin
                });
                createTask.Wait();
            }
        }
    }
}
