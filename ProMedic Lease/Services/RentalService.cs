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

        public void Add(Rental rental)
        {
            _rentalRepository.Add(rental);
        }

        public Rental GetById(long id)
        {
            return _rentalRepository.GetById(id);
        }

        public IEnumerable<Rental> GetAll()
        {
            return _rentalRepository.GetAll();
        }

        public void Update(Rental rental)
        {
            _rentalRepository.Update(rental);
        }

        public void Delete(long id)
        {
            _rentalRepository.Delete(id);
        }
    }
}
