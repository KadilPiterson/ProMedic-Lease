using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public class Position
    {
        public long Id { get; set; }
        public required string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
