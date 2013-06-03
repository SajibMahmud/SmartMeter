using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class LoadScheme
    {
        public int LoadSchemeId { get; set; }
        public int? CompanyId { get; set; }
        public string LoadSchemeName { get; set; }
        public string LoadSchemeDescription { get; set; }
        public double LoadFrom { get; set; }
        public double LoadTo { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<BillingRateConfig> BillingRateConfigs { get; set; }
        public virtual Company Company { get; set; }
    }
}
