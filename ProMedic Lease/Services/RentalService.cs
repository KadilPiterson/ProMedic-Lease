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

        public IEnumerable<Rental> Search(string searchTerm)
        {
            searchTerm = searchTerm?.ToLower() ?? "";
            return _rentalRepository.GetAll()
                .Where(r =>
                    (r.Equipment.Name != null && r.Equipment.Name.ToLower().Contains(searchTerm)) ||
                    (r.Client.FirstName != null && r.Client.FirstName.ToLower().Contains(searchTerm)) ||
                    (r.Client.LastName != null && r.Client.LastName.ToLower().Contains(searchTerm)) ||
                    (r.Employee.FirstName != null && r.Employee.FirstName.ToLower().Contains(searchTerm)) ||
                    (r.Employee.LastName != null && r.Employee.LastName.ToLower().Contains(searchTerm)) ||
                    (r.Comments != null && r.Comments.ToLower().Contains(searchTerm)) ||
                    r.StartDate.ToString("d").ToLower().Contains(searchTerm) ||
                    (r.EndDate.HasValue && r.EndDate.Value.ToString("d").ToLower().Contains(searchTerm)) ||
                    r.IsActive.ToString().ToLower().Contains(searchTerm)
                )
                .ToList();
        }
    }
}
