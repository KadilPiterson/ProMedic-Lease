using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public class Employee
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public string ActivationCode { get; set; }
        public bool IsActive { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Pesel { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public decimal Salary { get; set; }
        public Department Department { get; set; }
        public Position Position { get; set; }
    }
}
