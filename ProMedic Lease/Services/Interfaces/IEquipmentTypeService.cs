﻿using ProMedic_Lease.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Services.Interfaces
{
    public interface IEquipmentTypeService : IService<EquipmentType>
    {
        EquipmentType PrepareForUpdate(EquipmentType entity, string name, string description);

        EquipmentType CreateFormData(string name, string description);
    }
}
