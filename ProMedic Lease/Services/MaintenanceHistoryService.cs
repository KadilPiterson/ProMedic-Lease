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

        public void Add(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryRepository.Add(maintenanceHistory);
        }

        public MaintenanceHistory GetById(long id)
        {
            return _maintenanceHistoryRepository.GetById(id);
        }

        public IEnumerable<MaintenanceHistory> GetAll()
        {
            return _maintenanceHistoryRepository.GetAll();
        }

        public void Update(MaintenanceHistory maintenanceHistory)
        {
            _maintenanceHistoryRepository.Update(maintenanceHistory);
        }

        public void Delete(long id)
        {
            _maintenanceHistoryRepository.Delete(id);
        }
    }
}
