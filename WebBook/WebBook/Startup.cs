using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebBook
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
            services.AddRazorPages();
            services.AddControllersWithViews();
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
                app.UseExceptionHandler("/Error");
            }
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from my first middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my first return middleware");
            //});
            //app.Use(async (context, next) => {
            //    await context.Response.WriteAsync("Hello from my second middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my second return middleware");
            //});
            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync
            //      ("Hello from third middleware");
            //    await next();
            //});
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions() {
               FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
               RequestPath="/MyStaticFiles"
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();

                //endpoints.MapGet("/", async context =>
                //{
                //    if (env.IsDevelopment())
                //    {
                //        app.UseDeveloperExceptionPage();
                //      // await context.Response.WriteAsync("Environment is from developement");

                //    }
                //    //else if(env.IsProduction())
                //    //{
                //    //    await context.Response.WriteAsync("Environment is from production");
                //    //}
                //    //else if(env.IsStaging())
                //    //{
                //    //    await context.Response.WriteAsync("Environment is from stagging");
                //    //}
                //    //else
                //    //{
                //    //    await context.Response.WriteAsync(env.EnvironmentName);
                //    //}
                   

                //});
                endpoints.MapRazorPages();
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/nitish", async context =>
            //     {
            //         await context.Response.WriteAsync("Hello nitish");
            //     });
            //});
        }
    }
}
