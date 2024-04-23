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
        public static IdentityMap<Department> DepartmentsCache = new IdentityMap<Department>();
        public static IdentityMap<Position> PositionsCache = new IdentityMap<Position>();
        public static IdentityMap<EquipmentType> EquipmentTypesCache = new IdentityMap<EquipmentType>();
        public static IdentityMap<Client> ClientsCache = new IdentityMap<Client>();
        public static IdentityMap<Equipment> EquipmentsCache = new IdentityMap<Equipment>();
        public static IdentityMap<Employee> EmployeesCache = new IdentityMap<Employee>();
        public static IdentityMap<Rental> RentalsCache = new IdentityMap<Rental>();
    }
}
