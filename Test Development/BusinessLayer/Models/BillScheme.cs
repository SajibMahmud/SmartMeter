using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BillScheme
    {
        //public BillScheme()
        //{
        //    this.BillingRateConfigs = new HashSet<BillingRateConfig>();
        //    this.Devices = new HashSet<Device>();
        //}

        public int BillSchemeId { get; set; }
        public int CompanyId { get; set; }
        public string BillSchemeName { get; set; }
        public string BillSchemeDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<BillingRateConfig> BillingRateConfigs { get; set; }
        public virtual Company Company { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
    }
}
