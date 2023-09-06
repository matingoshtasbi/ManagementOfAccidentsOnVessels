using ManagementOfAccidentsOnVessels;
using ManagementOfAccidentsOnVessels.Application.Missions.Service;
using ManagementOfAccidentsOnVessels.Application.PortsManagement.Service;
using ManagementOfAccidentsOnVessels.Application.VesselsManagement;
using ManagementOfAccidentsOnVessels.Domain.VesselsManagement.Services;
using ManagementOfAccidentsOnVessels.Infrastructure.DataBaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ManagementOfAccidentsOnVessel
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            using (var scope = ServiceProvider.CreateScope())
            {
                using (var dbcontext = scope.ServiceProvider.GetService<ManagementOfAccidentsOnVesselsDbContext>())
                    dbcontext.Database.EnsureCreated();
            }

            Application.Run(ServiceProvider.GetRequiredService<MainForm>());
        }

        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddDbContext<ManagementOfAccidentsOnVesselsDbContext>(options =>
                    {
                        options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
                    });

                    services.AddTransient<ICommandQueryVesselService, CommandQueryVesselService>();
                    services.AddTransient<ICommandQueryMissionService, CommandQueryMissionService>();
                    services.AddTransient<ICommandQueryPortService, CommandQueryPortService>();

                    services.AddTransient<IVesselsManagementService, VesselsManagementService>();
                    services.AddTransient<MainForm>();
        
                });
        }
    }
}