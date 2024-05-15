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
        public static IdentityMap<Department> Departments = new IdentityMap<Department>();
        public static IdentityMap<Position> Positions = new IdentityMap<Position>();
        public static IdentityMap<EquipmentType> EquipmentTypes = new IdentityMap<EquipmentType>();
        public static IdentityMap<Client> Clients = new IdentityMap<Client>();
        public static IdentityMap<Equipment> Equipments = new IdentityMap<Equipment>();
        public static IdentityMap<Employee> Employees = new IdentityMap<Employee>();
        public static IdentityMap<Rental> Rentals = new IdentityMap<Rental>();
        public static IdentityMap<MaintenanceHistory> MaintenanceHistory = new IdentityMap<MaintenanceHistory>();
    }
}
