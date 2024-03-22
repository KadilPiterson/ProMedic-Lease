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
        public Equipment Equipment { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Client Client { get; set; }
        public Employee Employee { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
    }
}
