using ProMedic_Lease.Services;
using ProMedic_Lease.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Patterns.structural
{
    public class ServiceFacade : IServiceFacade
    {
        public IEmployeeService EmployeeService { get; private set; }
        public IDepartmentService DepartmentService { get; private set; }
        public IPositionService PositionService { get; private set; }
        public IClientService ClientService { get; private set; }
        public IEquipmentService EquipmentService { get; private set; }
        public IEquipmentTypeService EquipmentTypeService { get; private set; }
        public IRentalService RentalService { get; private set; }
        public IMaintenanceHistoryService MaintenanceHistoryService { get; private set; }

        public ServiceFacade(IEmployeeService employeeService, IDepartmentService departmentService, IPositionService positionService, IClientService clientService, IEquipmentService equipmentService, IRentalService rentalService, IMaintenanceHistoryService maintenanceHistoryService, IEquipmentTypeService equipmentTypeService)
        {
            MaintenanceHistoryService = maintenanceHistoryService;
            RentalService = rentalService;
            EmployeeService = employeeService;
            DepartmentService = departmentService;
            PositionService = positionService;
            ClientService = clientService;
            EquipmentService = equipmentService;
            RentalService = rentalService;
            EquipmentTypeService = equipmentTypeService;
        }
    }
}
