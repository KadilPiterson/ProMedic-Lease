using System;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration; // Dodajemy przestrzeñ nazw IConfiguration
using ProMedic_Lease.DataAccess.Repositories;
using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Services;
using ProMedic_Lease.Services.Interfaces;
using ProMedic_Lease.Utilities;
using System.Windows.Forms;
using ProMedic_Lease.Patterns.structural;

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
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                ApplicationConfiguration.Initialize();

                // Resolve the main form with dependencies injected
                var mainForm = serviceProvider.GetRequiredService<FormMain>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            // Konfigurujemy dostêp do pliku konfiguracyjnego
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Rejestrujemy IConfiguration w kontenerze
            services.AddSingleton<IConfiguration>(config);

            // Configure database manager
            services.AddSingleton<DatabaseManager>();

            // Configure repositories
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEquipmentRepository, EquipmentRepository>();
            services.AddScoped<IEquipmentTypeRepository, EquipmentTypeRepository>();
            services.AddScoped<IMaintenanceHistoryRepository, MaintenanceHistoryRepository>();
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmploymentFormRepository, EmploymentFormRepository>();

            // Configure services
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEquipmentService, EquipmentService>();
            services.AddScoped<IEquipmentTypeService, EquipmentTypeService>();
            services.AddScoped<IMaintenanceHistoryService, MaintenanceHistoryService>();
            services.AddScoped<IPositionService, PositionService>();
            services.AddScoped<IRentalService, RentalService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmploymentFormService, EmploymentFormService>();
            services.AddScoped<IServiceFacade, ServiceFacade>();

            services.AddScoped<FormMain>();
        }
    }
}
