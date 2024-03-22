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

        public void AddEmployee(Employee employee)
        {
            _employeeRepository.AddEmployee(employee);
        }

        public Employee GetEmployeeById(long id)
        {
            return _employeeRepository.GetEmployeeById(id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAllEmployees();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeRepository.UpdateEmployee(employee);
        }

        public void DeleteEmployee(long id)
        {
            _employeeRepository.DeleteEmployee(id);
        }
    }
}
