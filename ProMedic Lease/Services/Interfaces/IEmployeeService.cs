using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IEmployeeService
    {
        void AddEmployee(Employee employee);
        Employee GetEmployeeById(long id);
        IEnumerable<Employee> GetAllEmployees();
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(long id);
    }
}
