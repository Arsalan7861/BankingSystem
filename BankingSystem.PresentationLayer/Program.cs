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
                    services.AddTransient<Form1>(); // Register Form1
                })
                .Build();

            var connectionString = configuration.GetConnectionString("BankingDb");

            var accountService = new AccountManager(connectionString);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(accountService));
        }
    }
}