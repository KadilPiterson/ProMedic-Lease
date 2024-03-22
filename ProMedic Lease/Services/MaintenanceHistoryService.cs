using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services
{
    public class MaintenanceHistoryService : IMaintenanceHistoryService
    {
        private readonly IMaintenanceHistoryRepository _maintenanceHistoryRepository;

        public MaintenanceHistoryService(IMaintenanceHistoryRepository maintenanceHistoryRepository)
        {
            _maintenanceHistoryRepository = maintenanceHistoryRepository;
        }

        public void AddMaintenanceHistory(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryRepository.AddMaintenanceHistory(maintenanceHistory);
        }

        public MaintenanceHistory GetMaintenanceHistoryById(long id)
        {
            return _maintenanceHistoryRepository.GetMaintenanceHistoryById(id);
        }

        public IEnumerable<MaintenanceHistory> GetAllMaintenanceHistory()
        {
            return _maintenanceHistoryRepository.GetAllMaintenanceHistory();
        }

        public void UpdateMaintenanceHistory(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryRepository.UpdateMaintenanceHistory(maintenanceHistory);
        }

        public void DeleteMaintenanceHistory(long id)
        {
            _maintenanceHistoryRepository.DeleteMaintenanceHistory(id);
        }
    }
}
