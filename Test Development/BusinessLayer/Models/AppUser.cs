using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class AppUser
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool Status { get; set; }
        public bool IsLoggedIn { get; set; }
        public DateTime? LastLogIn { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public virtual ICollection<Address> CreatedAddresses { get; set; }
        public virtual ICollection<Address> UpdatedAddresses { get; set; }
        public virtual ICollection<Bill> CreatedBills { get; set; }
        public virtual ICollection<Bill> UpdatedBills { get; set; }
        public virtual ICollection<BillingPeriod> CreatedBillingPeriods { get; set; }
        public virtual ICollection<BillingPeriod> UpdatedBillingPeriods { get; set; }
        public virtual ICollection<BillingRateConfig> CreatedBillingRateConfigs { get; set; }
        public virtual ICollection<BillingRateConfig> UpdatedBillingRateConfigs { get; set; }
        public virtual ICollection<BillingRate> CreatedBillingRates { get; set; }
        public virtual ICollection<BillingRate> UpdatedBillingRates { get; set; }
        public virtual ICollection<Company> CreatedCompanies { get; set; }
        public virtual ICollection<Company> UpdatedCompanies { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<CompanyUser> CreatedCompanyUsers { get; set; }
        public virtual ICollection<CompanyUser> UpdatedCompanyUsers { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Device> CreatedDevices { get; set; }
        public virtual ICollection<Device> UpdatedDevices { get; set; }
        public virtual ICollection<LimitType> CreatedLimitTypes { get; set; }
        public virtual ICollection<LimitType> UpdatedLimitTypes { get; set; }
        public virtual ICollection<MeterProperty> CreatedMeterProperties { get; set; }
        public virtual ICollection<MeterProperty> UpdatedMeterProperties { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
