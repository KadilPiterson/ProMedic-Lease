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
    public class EquipmentTypeService : IEquipmentTypeService
    {
        private readonly IEquipmentTypeRepository _equipmentTypeRepository;

        public EquipmentTypeService(IEquipmentTypeRepository equipmentTypeRepository)
        {
            _equipmentTypeRepository = equipmentTypeRepository;
        }

        public void AddEquipmentType(EquipmentType equipmentType)
        {
            _equipmentTypeRepository.AddEquipmentType(equipmentType);
        }

        public EquipmentType GetEquipmentTypeById(long id)
        {
            return _equipmentTypeRepository.GetEquipmentTypeById(id);
        }

        public IEnumerable<EquipmentType> GetAllEquipmentTypes()
        {
            return _equipmentTypeRepository.GetAllEquipmentTypes();
        }

        public void UpdateEquipmentType(EquipmentType equipmentType)
        {
            _equipmentTypeRepository.UpdateEquipmentType(equipmentType);
        }

        public void DeleteEquipmentType(long id)
        {
            _equipmentTypeRepository.DeleteEquipmentType(id);
        }
    }
}
