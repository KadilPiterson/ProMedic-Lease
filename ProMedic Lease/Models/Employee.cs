using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public class Employee : Person
    {
        public required string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string ActivationCode { get; set; }
        public bool IsActive { get; set; }
        public required DateTime EmploymentDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public required decimal Salary { get; set; }
        public required Department Department { get; set; }
        public required Position Position { get; set; }
    }
}
