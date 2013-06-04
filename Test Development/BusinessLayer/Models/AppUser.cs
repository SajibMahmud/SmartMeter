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

        [InverseProperty("CreatedBy")]
        public virtual ICollection<Address> CreatedAddresses { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<Address> UpdatedAddresses { get; set; }

        [InverseProperty("CreatedBy")]
        public virtual ICollection<Bill> CreatedBills { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<Bill> UpdatedBills { get; set; }

        [InverseProperty("CreatedBy")]
        public virtual ICollection<BillingPeriod> CreatedBillingPeriods { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<BillingPeriod> UpdatedBillingPeriods { get; set; }
        
        [InverseProperty("CreatedBy")]
        public virtual ICollection<BillingRateConfig> CreatedBillingRateConfigs { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<BillingRateConfig> UpdatedBillingRateConfigs { get; set; }

        [InverseProperty("CreatedBy")]
        public virtual ICollection<BillingRate> CreatedBillingRates { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<BillingRate> UpdatedBillingRates { get; set; }
        
        [InverseProperty("CreatedBy")]
        public virtual ICollection<Company> CreatedCompanies { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<Company> UpdatedCompanies { get; set; }

        [InverseProperty("UserId")]
        public virtual ICollection<CompanyUser> CompanyUsers { get; set; }
        [InverseProperty("CreatedBy")]
        public virtual ICollection<CompanyUser> CreatedCompanyUsers { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<CompanyUser> UpdatedCompanyUsers { get; set; }

        [InverseProperty("UserId")]
        public virtual ICollection<Device> Devices { get; set; }
        [InverseProperty("CreatedBy")]
        public virtual ICollection<Device> CreatedDevices { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<Device> UpdatedDevices { get; set; }

        [InverseProperty("CreatedBy")]
        public virtual ICollection<LimitType> CreatedLimitTypes { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<LimitType> UpdatedLimitTypes { get; set; }

        [InverseProperty("CreatedBy")]
        public virtual ICollection<MeterProperty> CreatedMeterProperties { get; set; }
        [InverseProperty("UpdatedBy")]
        public virtual ICollection<MeterProperty> UpdatedMeterProperties { get; set; }

        [InverseProperty("UserId")]
        public virtual ICollection<UserLog> UserLogs { get; set; }
        [InverseProperty("UserId")]
        public virtual ICollection<UserPermission> UserPermissions { get; set; }
        [InverseProperty("UserId")]
        public virtual UserProfile UserProfile { get; set; }
        [InverseProperty("UserId")]
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
