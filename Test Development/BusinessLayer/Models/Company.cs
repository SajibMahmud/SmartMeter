using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public int AddressId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual Address Address { get; set; }
        public virtual AppUser Creator { get; set; }
        public virtual AppUser Updator { get; set; }
        public virtual ICollection<BillingPeriod> BillingPeriods { get; set; }
        public virtual ICollection<BillScheme> BillSchemes { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<LoadScheme> LoadSchemes { get; set; }
        public virtual ICollection<TimeScheme> TimeSchemes { get; set; }
    }
}
