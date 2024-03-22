using ProMedic_Lease.DataAccess.Repositories.Interfaces;
using ProMedic_Lease.Models;
using ProMedic_Lease.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services
{
    public class RentalService : IRentalService
    {
        private readonly IRentalRepository _rentalRepository;

        public RentalService(IRentalRepository rentalRepository)
        {
            _rentalRepository = rentalRepository;
        }

        public void AddRental(Rental rental)
        {
            _rentalRepository.AddRental(rental);
        }

        public Rental GetRentalById(long id)
        {
            return _rentalRepository.GetRentalById(id);
        }

        public IEnumerable<Rental> GetAllRentals()
        {
            return _rentalRepository.GetAllRentals();
        }

        public void UpdateRental(Rental rental)
        {
            _rentalRepository.UpdateRental(rental);
        }

        public void DeleteRental(long id)
        {
            _rentalRepository.DeleteRental(id);
        }
    }
}
