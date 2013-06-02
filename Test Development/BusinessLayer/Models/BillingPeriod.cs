using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BillingPeriod
    {
        //public BillingPeriod()
        //{
        //    this.Bills = new HashSet<Bill>();
        //}

        public int BillingPeriodId { get; set; }
        public DateTime PeriodStartsFrom { get; set; }
        public string PeriodEndsAt { get; set; }
        public int? CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Company Company { get; set; }
    }
}
