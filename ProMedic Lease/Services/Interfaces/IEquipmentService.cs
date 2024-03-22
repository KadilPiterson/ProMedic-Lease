using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IEquipmentService
    {
        void AddEquipment(Equipment equipment);
        Equipment GetEquipmentById(long id);
        IEnumerable<Equipment> GetAllEquipment();
        void UpdateEquipment(Equipment equipment);
        void DeleteEquipment(long id);
    }
}
