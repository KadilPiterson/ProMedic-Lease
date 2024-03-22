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
        public string Name { get; set; }
        public string InventoryNumber { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string InvoiceNumber { get; set; }
        public string IdentificationNumber { get; set; }
        public bool IsServiced { get; set; }
        public bool IsInTransit { get; set; }
        public DateTime? DisposalDate { get; set; }
        public int Status { get; set; }
        public long EquipmentTypeId { get; set; }
        public decimal DailyRentalPrice { get; set; }
    }
}
