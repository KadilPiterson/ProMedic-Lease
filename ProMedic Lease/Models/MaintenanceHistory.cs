using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public class MaintenanceHistory
    {
        public long Id { get; set; }
        public required long EquipmentId { get; set; }
        public required long EmployeeId { get; set; }
        public required decimal Cost { get; set; }
        public required int Time { get; set; }
        public required DateTime Date { get; set; }
        public string? Description { get; set; }
    }
}
