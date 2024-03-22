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
        public long EquipmentId { get; set; }
        public long EmployeeId { get; set; }
        public decimal Cost { get; set; }
        public int Time { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}
