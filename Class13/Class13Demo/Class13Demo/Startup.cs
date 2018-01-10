using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Class13Demo.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Class13Demo
{
    public class Startup
    {
        public IConfiguration Configuration { get;}

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }


        // Workflow:
        /*
         * 1. Setup Startup class with MVC
            2. Add Model Views Controller Folders
            3. Add Model Classes
            4. Create Data folder
            5. Add DBContext class
            6. Add Dependency Injection to Startup class (IConfiguration setup)
            7. Add New services (services.add Mvc && services.AddDbContext)
            8. Add json configuration file (Change the name of the database)
            9. Update Database
                ` Install-Package Microsoft.EntityFrameworkCore.Tools` <br />
                `Add-Migration Initial` <br />
                `Update-Database`
            10. See SQL Object Explorer and see DB
            11. Add DI to HomeController
            12. Create (other) Controllers and view
            16. Save data into database
            17. Use Static files in ConfigureServices
        */

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<CatFarmDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvcWithDefaultRoute();
            app.UseStaticFiles();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
