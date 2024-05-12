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
        public required Equipment Equipment { get; set; }
        public required Employee Employee { get; set; }
        public required decimal Cost { get; set; }
        public required DateTime DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
