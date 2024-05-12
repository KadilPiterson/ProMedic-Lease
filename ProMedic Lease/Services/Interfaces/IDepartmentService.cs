using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IDepartmentService : IService<Department>
    {
        Department PrepareForUpdate(Department entity, string name);

        Department CreateFormData(string name);
    }
}
