using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace ConvertConsoleAppIntoWebApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CrearteHostBulider(args).Build().Run();
        }
        public static IHostBuilder CrearteHostBulider(string[] arge) =>
            Host.CreateDefaultBuilder(arge).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
        
    }
}
