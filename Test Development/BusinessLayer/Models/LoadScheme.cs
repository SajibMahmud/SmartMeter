using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class LoadScheme
    {
        //public LoadScheme()
        //{
        //    this.BillingRateConfigs = new HashSet<BillingRateConfig>();
        //}

        public int LoadSchemeId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string LoadSchemeName { get; set; }
        public string LoadSchemeDescription { get; set; }
        public double LoadFrom { get; set; }
        public double LoadTo { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

        public virtual ICollection<BillingRateConfig> BillingRateConfigs { get; set; }
        public virtual Company Company { get; set; }
    }
}
