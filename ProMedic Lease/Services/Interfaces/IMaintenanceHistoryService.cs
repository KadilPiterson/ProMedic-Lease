using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IMaintenanceHistoryService
    {
        void AddMaintenanceHistory(MaintenanceHistory maintenanceHistory);
        MaintenanceHistory GetMaintenanceHistoryById(long id);
        IEnumerable<MaintenanceHistory> GetAllMaintenanceHistory();
        void UpdateMaintenanceHistory(MaintenanceHistory maintenanceHistory);
        void DeleteMaintenanceHistory(long id);
    }
}
