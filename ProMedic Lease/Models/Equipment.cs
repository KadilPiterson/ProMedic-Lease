using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProMedic_Lease.Models
{
    public class Equipment
    {
        public long Id { get; set; }
        public required string Name { get; set; }
        public required string InventoryNumber { get; set; }
        public required DateTime PurchaseDate { get; set; }
        public required string InvoiceNumber { get; set; }
        public required string IdentificationNumber { get; set; }
        public bool IsServiced { get; set; }
        public bool IsInTransit { get; set; }
        public DateTime? DisposalDate { get; set; }
        public bool IsActive { get; set; }
        public required EquipmentType EquipmentType { get; set; }
        public required decimal DailyRentalPrice { get; set; }

        public override string ToString()
        {
            return Name + " " + InventoryNumber;
        }
    }
}
