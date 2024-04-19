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

        public void Add(EquipmentType equipmentType)
        {
            _equipmentTypeRepository.Add(equipmentType);
        }

        public EquipmentType GetById(long id)
        {
            return _equipmentTypeRepository.GetById(id);
        }

        public IEnumerable<EquipmentType> GetAll()
        {
            return _equipmentTypeRepository.GetAll();
        }

        public void Update(EquipmentType equipmentType)
        {
            _equipmentTypeRepository.Update(equipmentType);
        }

        public void Delete(long id)
        {
            _equipmentTypeRepository.Delete(id);
        }
    }
}
