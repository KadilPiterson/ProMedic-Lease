using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IEquipmentTypeService
    {
        void AddEquipmentType(EquipmentType equipmentType);
        EquipmentType GetEquipmentTypeById(long id);
        IEnumerable<EquipmentType> GetAllEquipmentTypes();
        void UpdateEquipmentType(EquipmentType equipmentType);
        void DeleteEquipmentType(long id);
    }
}
