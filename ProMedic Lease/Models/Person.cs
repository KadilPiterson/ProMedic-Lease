using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public abstract class Person
    {
        public long Id { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Pesel { get; set; }
        public required string Street { get; set; }
        public required int HouseNumber { get; set; }
        public required int ApartmentNumber { get; set; }
        public required string PostalCode { get; set; }
        public required string City { get; set; }
        public required string Email { get; set; }
        public required string Phone { get; set; }
        public bool IsActive { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}
