using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class AppUser
    {
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

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Address> Addresses1 { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Bill> Bills1 { get; set; }
        public virtual ICollection<BillingPeriod> BillingPeriods { get; set; }
        public virtual ICollection<BillingPeriod> BillingPeriods1 { get; set; }
        public virtual ICollection<BillingRateConfig> BillingRateConfigs { get; set; }
        public virtual ICollection<BillingRate> BillingRates { get; set; }
        public virtual ICollection<BillingRateConfig> BillingRateConfigs1 { get; set; }
        public virtual ICollection<BillingRate> BillingRates1 { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Company> Companies1 { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers1 { get; set; }
        public virtual ICollection<CompanyUser> CompanyUsers2 { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<Device> Devices1 { get; set; }
        public virtual ICollection<Device> Devices2 { get; set; }
        public virtual ICollection<LimitType> LimitTypes { get; set; }
        public virtual ICollection<LimitType> LimitTypes1 { get; set; }
        public virtual ICollection<MeterProperty> MeterProperties { get; set; }
        public virtual ICollection<MeterProperty> MeterProperties1 { get; set; }
        public virtual ICollection<UserLog> UserLogs { get; set; }
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        public virtual UserProfile UserProfile { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
