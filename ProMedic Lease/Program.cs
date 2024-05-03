using System;
using Microsoft.Extensions.DependencyInjection;
using ProMedic_Lease.DataAccess.Repositories;
using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Services;
using ProMedic_Lease.Services.Interfaces;
using ProMedic_Lease.Utilities;
using WinFormsApp1;

namespace ProMedic_Lease
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize services
            var services = new ServiceCollection();
            ConfigureServices(services);

            // Build service provider
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                ApplicationConfiguration.Initialize();

                // Resolve the main form with dependencies injected
                var mainForm = serviceProvider.GetRequiredService<FormMain>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Add scoped instances for interfaces and repositories
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IClientService, ClientService>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddScoped<IEquipmentRepository, EquipmentRepository>();
            services.AddScoped<IEquipmentService, EquipmentService>();

            services.AddScoped<IEquipmentTypeRepository, EquipmentTypeRepository>();
            services.AddScoped<IEquipmentTypeService, EquipmentTypeService>();

            services.AddScoped<IEquipmentTypeRepository, EquipmentTypeRepository>();
            services.AddScoped<IEquipmentTypeService, EquipmentTypeService>();

            services.AddScoped<IMaintenanceHistoryRepository, MaintenanceHistoryRepository>();
            services.AddScoped<IMaintenanceHistoryService, MaintenanceHistoryService>();

            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<IRentalService, RentalService>();

            // Add singleton instance of DatabaseManager or as scoped based on your needs
            services.AddSingleton<DatabaseManager>();

            // Assuming Form1 takes IRentalService as a dependency
            services.AddScoped<FormMain>();
        }
    }
}
