using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class BillingRate
    {
        public int BillingRateId { get; set; }
        public int BillingRateConfigId { get; set; }
        public Nullable<int> LimitTypeId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreteadBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual BillingRateConfig BillingRateConfig { get; set; }
        public virtual LimitType LimitType { get; set; }
    }
}
