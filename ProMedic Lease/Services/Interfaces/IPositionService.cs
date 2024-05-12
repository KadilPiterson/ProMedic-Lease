using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IPositionService : IService<Position>
    {
        Position PrepareForUpdate(Position entity, string name);

        Position CreateFormData(string name);
    }
}
