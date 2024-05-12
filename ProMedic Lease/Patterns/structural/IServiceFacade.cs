using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Patterns.structural
{
    public interface IServiceFacade
    {
        IRentalService RentalService { get; }
        IEmployeeService EmployeeService { get; }
        IClientService ClientService { get; }
        IEquipmentService EquipmentService { get; }
        IEquipmentTypeService EquipmentTypeService { get; }
        IMaintenanceHistoryService MaintenanceHistoryService { get; }
        IDepartmentService DepartmentService { get; }
        IPositionService PositionService { get; }
    }
}
