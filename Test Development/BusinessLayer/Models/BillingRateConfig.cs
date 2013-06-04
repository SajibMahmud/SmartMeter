using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class BillingRateConfig
    {
        public int BillingRateConfigId { get; set; }
        public int BillSchemeId { get; set; }
        public int? TimeSchemeId { get; set; }
        public int? LoadSchemeId { get; set; }
        public DateTime AppliedDateFrom { get; set; }
        public DateTime AppliedDateTo { get; set; }
        public double Vat { get; set; }
        public string Currency { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("CretaedBy")]
        public virtual AppUser Creator { get; set; }
        [ForeignKey("UpdatedBy")]
        public virtual AppUser Updator { get; set; }
        public virtual ICollection<BillingRate> BillingRates { get; set; }
        public virtual BillScheme BillScheme { get; set; }
        public virtual LoadScheme LoadScheme { get; set; }
        public virtual TimeScheme TimeScheme { get; set; }
    }
}
