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
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;

        public EquipmentService(IEquipmentRepository equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }

        public void AddEquipment(Equipment equipment)
        {
            _equipmentRepository.AddEquipment(equipment);
        }

        public Equipment GetEquipmentById(long id)
        {
            return _equipmentRepository.GetEquipmentById(id);
        }

        public IEnumerable<Equipment> GetAllEquipment()
        {
            return _equipmentRepository.GetAllEquipment();
        }

        public void UpdateEquipment(Equipment equipment)
        {
            _equipmentRepository.UpdateEquipment(equipment);
        }

        public void DeleteEquipment(long id)
        {
            _equipmentRepository.DeleteEquipment(id);
        }
    }
}
