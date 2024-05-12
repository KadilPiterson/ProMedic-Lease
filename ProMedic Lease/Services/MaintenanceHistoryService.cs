using ProMedic_Lease.DataAccess.Repositories;
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

        public IEnumerable<MaintenanceHistory> Search(string searchTerm)
        {
            searchTerm = searchTerm?.ToLower() ?? "";
            return _maintenanceHistoryRepository.GetAll()
                .Where(r =>
                    (r.Equipment.Name != null && r.Equipment.Name.ToLower().Contains(searchTerm)) ||
                    (r.Equipment.InventoryNumber != null && r.Equipment.InventoryNumber.ToLower().Contains(searchTerm)) ||
                    (r.Equipment.InvoiceNumber != null && r.Equipment.InventoryNumber.ToLower().Contains(searchTerm)) ||
                    (r.Employee.FirstName != null && r.Employee.FirstName.ToLower().Contains(searchTerm)) ||
                    (r.Employee.LastName != null && r.Employee.LastName.ToLower().Contains(searchTerm)) ||
                    (r.Description != null && r.Description.ToLower().Contains(searchTerm)) ||
                    r.DateStart.ToString("d").ToLower().Contains(searchTerm) ||
                    (r.DateEnd.HasValue && r.DateEnd.Value.ToString("d").ToLower().Contains(searchTerm)) ||
                    r.IsActive.ToString().ToLower().Contains(searchTerm)
                )
                .ToList();
        }
    }
}
