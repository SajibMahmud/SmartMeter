using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class AppUser
    {
        //public AppUser()
        //{
        //    this.Addresses = new HashSet<Address>();
        //    this.Addresses1 = new HashSet<Address>();
        //    this.Bills = new HashSet<Bill>();
        //    this.Bills1 = new HashSet<Bill>();
        //    this.BillingPeriods = new HashSet<BillingPeriod>();
        //    this.BillingPeriods1 = new HashSet<BillingPeriod>();
        //    this.BillingRateConfigs = new HashSet<BillingRateConfig>();
        //    this.BillingRates = new HashSet<BillingRate>();
        //    this.BillingRateConfigs1 = new HashSet<BillingRateConfig>();
        //    this.BillingRates1 = new HashSet<BillingRate>();
        //    this.Companies = new HashSet<Company>();
        //    this.Companies1 = new HashSet<Company>();
        //    this.CompanyUsers = new HashSet<CompanyUser>();
        //    this.CompanyUsers1 = new HashSet<CompanyUser>();
        //    this.CompanyUsers2 = new HashSet<CompanyUser>();
        //    this.Devices = new HashSet<Device>();
        //    this.Devices1 = new HashSet<Device>();
        //    this.Devices2 = new HashSet<Device>();
        //    this.LimitTypes = new HashSet<LimitType>();
        //    this.LimitTypes1 = new HashSet<LimitType>();
        //    this.MeterProperties = new HashSet<MeterProperty>();
        //    this.MeterProperties1 = new HashSet<MeterProperty>();
        //    this.UserLogs = new HashSet<UserLog>();
        //    this.UserPermissions = new HashSet<UserPermission>();
        //    this.UserRoles = new HashSet<UserRole>();
        //}

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool Status { get; set; }
        public bool IsLoggedIn { get; set; }
        public Nullable<System.DateTime> LastLogIn { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

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
