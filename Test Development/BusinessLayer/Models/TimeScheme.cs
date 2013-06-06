using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class TimeScheme
    {
        public TimeScheme()
        {
            this.BillingRateConfigs = new HashSet<BillingRateConfig>();
        }
        public int TimeSchemeId { get; set; }
        public int? CompanyId { get; set; }
        public string TimeSchemeName { get; set; }
        public string TimeSchemeDescription { get; set; }
        public DateTime StartsAt { get; set; }
        public DateTime EndsAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<BillingRateConfig> BillingRateConfigs { get; set; }
        public virtual Company Company { get; set; }
    }
}
