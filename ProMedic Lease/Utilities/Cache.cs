using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Utilities
{
    public static class Cache
    {
        public static Dictionary<long, Department> DepartmentsCache = new Dictionary<long, Department>();
        public static Dictionary<long, Position> PositionsCache = new Dictionary<long, Position>();
        public static Dictionary<long, EquipmentType> EquipmentTypesCache = new Dictionary<long, EquipmentType>();
        public static Dictionary<long, Client> ClientsCache = new Dictionary<long, Client>();
        public static Dictionary<long, Equipment> EquipmentsCache = new Dictionary<long, Equipment>();
    }
}
