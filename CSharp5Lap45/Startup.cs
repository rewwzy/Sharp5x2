using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using CSharp5Lap45.Service.IServices;
using CSharp5Lap45.Service.Services;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using CSharp5Lap45.Data.EF.DBContext;
using Microsoft.EntityFrameworkCore;

namespace CSharp5Lap45
{
    public class Startup
    {
        private IHostingEnvironment _IHostingEnviroment;
        public Startup(IConfiguration configuration, IHostingEnvironment ihostingEnvironment)
        {
            Configuration = configuration;
            _IHostingEnviroment = ihostingEnvironment;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<DBContextFPOLY>(x => x.UseSqlServer(Configuration.GetConnectionString("FPTPOLYCHSARP5DH")));

            #region Add Services Transient
            services.AddTransient<IStudentService,StudentService>();
            services.AddTransient<IClassService,ClassService>();
            #endregion
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

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