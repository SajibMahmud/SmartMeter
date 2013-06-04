using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class LimitType
    {
        public int LimitTypeId { get; set; }
        public string LimitName { get; set; }
        public string LimitDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        [ForeignKey("CretaedBy")]
        public virtual AppUser Creator { get; set; }
        [ForeignKey("UpdatedBy")]
        public virtual AppUser Updator { get; set; }
        public virtual ICollection<BillingRate> BillingRates { get; set; }
    }
}
