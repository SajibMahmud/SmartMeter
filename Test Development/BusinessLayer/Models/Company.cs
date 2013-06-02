using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Company
    {
        //public Company()
        //{
        //    this.BillingPeriods = new HashSet<BillingPeriod>();
        //    this.BillSchemes = new HashSet<BillScheme>();
        //    this.CompanyUsers = new HashSet<CompanyUser>();
        //    this.LoadSchemes = new HashSet<LoadScheme>();
        //    this.TimeSchemes = new HashSet<TimeScheme>();
        //}

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
        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<BillingPeriod> BillingPeriods { get; set; }
        public virtual ICollection<BillScheme> BillSchemes { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<LoadScheme> LoadSchemes { get; set; }
        public virtual ICollection<TimeScheme> TimeSchemes { get; set; }
    }
}
