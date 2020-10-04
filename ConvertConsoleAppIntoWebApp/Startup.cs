using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;


namespace ConvertConsoleAppIntoWebApp
{
   public class Startup
    {
        public void ConfigurationServices(IServiceCollection services)
        {

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context, next) => 
            {
                await context.Response.WriteAsync("\nHello this second ");
                await next();
                await context.Response.WriteAsync("\nHusanov Doston");
            }
            );
            app.Use(async (context, next) => 
            {
                await context.Response.WriteAsync("\nKamol Hasanov");
            }
            );
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                 {
                     await context.Response.WriteAsync("Hello! This project Convert Console Application into Web Application");

                 }
                );
            });
        }
    }
}
