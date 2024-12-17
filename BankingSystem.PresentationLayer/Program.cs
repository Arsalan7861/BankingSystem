using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BankingSystem.EntityLayer.Models;
using BankingSystem.DataAccessLayer;
using BankingSystem.BusinessLayer.Concrete;
using BankingSystem.BusinessLayer.Abstract;

namespace BankingSystem.PresentationLayer
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Build the configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Set up the dependency injection
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<BankingDbContext>(options =>
                        options.UseNpgsql(configuration.GetConnectionString("BankingDb")));
                    services.AddSingleton(configuration.GetConnectionString("BankingDb")); // Register connection string
                    services.AddTransient<Form>(); // Register Form1
                })
                .Build();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var form1 = services.GetRequiredService<Form>();
                Application.Run(form1);
            }
        }
    }
}