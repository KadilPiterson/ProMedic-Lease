﻿using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IEmployeeService : IService<Employee>
    {
        IEnumerable<Employee> GetAllActive();
        IEnumerable<Employee> GetAllSeller();
        IEnumerable<Employee> GetAllConservator();
    }
}
