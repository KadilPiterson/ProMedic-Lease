using ProMedic_Lease.DataAccess.Repositories;
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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Add(Employee employee)
        {
            _employeeRepository.Add(employee);
        }

        public Employee GetById(long id)
        {
            return _employeeRepository.GetById(id);
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public void Update(Employee employee)
        {
            _employeeRepository.Update(employee);
        }

        public void Delete(long id)
        {
            _employeeRepository.Delete(id);
        }

        public IEnumerable<Employee> GetAllActive()
        {
            return _employeeRepository.GetAll().Where(e => e.IsActive == true).ToList();
        }

        public IEnumerable<Employee> GetAllSeller() 
        {
            return _employeeRepository.GetAll().Where(e => e.Position.Id == 1).ToList();
        }

        public IEnumerable<Employee> GetAllConservator()
        {
            return _employeeRepository.GetAll().Where(e => e.Position.Id == 2).ToList();
        }

        public IEnumerable<Employee> Search(string searchTerm)
        {
            searchTerm = searchTerm?.ToLower() ?? "";
            return _employeeRepository.GetAll()
                .Where(e => e.FirstName.ToLower().Contains(searchTerm) ||
                            e.LastName.ToLower().Contains(searchTerm) ||
                            e.Email.ToLower().Contains(searchTerm) ||
                            e.Phone.ToLower().Contains(searchTerm) ||
                            e.Street.ToLower().Contains(searchTerm) ||      
                            e.City.ToLower().Contains(searchTerm) ||        
                            e.PostalCode.ToLower().Contains(searchTerm))
                .ToList();
        }
    }
}
