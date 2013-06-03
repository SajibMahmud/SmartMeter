using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public int DeviceId { get; set; }
        public int? BillingPeriodId { get; set; }
        public double TotalUnit { get; set; }
        public double TotalUnitCost { get; set; }
        public double TotalVat { get; set; }
        public double Surcharge { get; set; }
        public double TotalCost { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual BillingPeriod BillingPeriod { get; set; }
        public virtual Device Device { get; set; }
    }
}
