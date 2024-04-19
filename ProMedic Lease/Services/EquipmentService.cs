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

        public void Add(Equipment equipment)
        {
            _equipmentRepository.Add(equipment);
        }

        public Equipment GetById(long id)
        {
            return _equipmentRepository.GetById(id);
        }

        public IEnumerable<Equipment> GetAll()
        {
            return _equipmentRepository.GetAll();
        }

        public void Update(Equipment equipment)
        {
            _equipmentRepository.Update(equipment);
        }

        public void Delete(long id)
        {
            _equipmentRepository.Delete(id);
        }
    }
}
