using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual ICollection<BillingRate> BillingRates { get; set; }
    }
}
