﻿using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IClientService : IService<Client>
    {
        IEnumerable<Client> GetAllActive();
    }
}
