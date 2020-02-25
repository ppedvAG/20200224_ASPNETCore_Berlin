using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreKurs_Berlin.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace AspNetCoreKurs_Berlin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                IHost hostBuilder = CreateHostBuilder(args).Build();

                using (var scope = hostBuilder.Services.CreateScope())
                {
                    var services = scope.ServiceProvider;

                    DataSeed.Initialize(services);
                }

                hostBuilder.Run();
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }








        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
