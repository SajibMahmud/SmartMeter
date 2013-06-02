using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class BillingRateConfig
    {
        //public BillingRateConfig()
        //{
        //    this.BillingRates = new HashSet<BillingRate>();
        //}

        public int BillingRateConfigId { get; set; }
        public int BillSchemeId { get; set; }
        public Nullable<int> TimeSchemeId { get; set; }
        public Nullable<int> LoadSchemeId { get; set; }
        public System.DateTime AppliedDateFrom { get; set; }
        public System.DateTime AppliedDateTo { get; set; }
        public double VAT { get; set; }
        public string Currency { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<BillingRate> BillingRates { get; set; }
        public virtual BillScheme BillScheme { get; set; }
        public virtual LoadScheme LoadScheme { get; set; }
        public virtual TimeScheme TimeScheme { get; set; }
    }
}
