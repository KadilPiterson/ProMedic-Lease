using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IRentalService
    {
        void AddRental(Rental rental);
        Rental GetRentalById(long id);
        IEnumerable<Rental> GetAllRentals();
        void UpdateRental(Rental rental);
        void DeleteRental(long id);
    }
}
