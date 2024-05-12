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
    public class EmploymentFormService : IEmploymentFormService
    {
        private readonly IEmploymentFormRepository _employmentFormRepository;

        public EmploymentFormService(IEmploymentFormRepository employmentFormRepository)
        {
            _employmentFormRepository = employmentFormRepository;
        }

        public void Add(EmploymentForm employmentForm)
        {
            _employmentFormRepository.Add(employmentForm);
        }

        public EmploymentForm GetById(long id)
        {
            return _employmentFormRepository.GetById(id);
        }

        public IEnumerable<EmploymentForm> GetAll()
        {
            return _employmentFormRepository.GetAll();
        }

        public void Update(EmploymentForm employmentForm)
        {
            _employmentFormRepository.Update(employmentForm);
        }

        public void Delete(long id)
        {
            _employmentFormRepository.Delete(id);
        }

        public IEnumerable<EmploymentForm> Search(string searchTerm)
        {
            throw new NotImplementedException();
        }
    }
}
