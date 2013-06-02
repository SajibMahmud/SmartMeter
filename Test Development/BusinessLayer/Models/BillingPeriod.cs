using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class BillingPeriod
    {
        //public BillingPeriod()
        //{
        //    this.Bills = new HashSet<Bill>();
        //}

        public int BillingPeriodId { get; set; }
        public System.DateTime PeriodStartsFrom { get; set; }
        public string PeriodEndsAt { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual Company Company { get; set; }
    }
}
