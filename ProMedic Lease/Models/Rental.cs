using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public class Rental
    {
        public long Id { get; set; }
        public required Equipment Equipment { get; set; }
        public required DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public required Client Client { get; set; }
        public required Employee Employee { get; set; }
        public string? Comments { get; set; }
        public bool IsActive { get; set; }
    }
}
