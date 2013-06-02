using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public  class LimitType
    {
        //public LimitType()
        //{
        //    this.BillingRates = new HashSet<BillingRate>();
        //}

        public int LimitTypeId { get; set; }
        public string LimitName { get; set; }
        public string LimitDescription { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<BillingRate> BillingRates { get; set; }
    }
}
