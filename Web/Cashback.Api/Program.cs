using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Cashback.DI.Interface;

namespace Cashback.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                var host = CreateHostBuilder(args).Build();

                // chama o serviço de Façade para preparar ambiente
                using (var scope = host.Services.CreateScope())
                {
                    var facade = (IBootstrapFacade)scope.ServiceProvider.GetService(typeof(IBootstrapFacade));
                    facade.PrepareEnvironment();
                }

                host.Run();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
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
