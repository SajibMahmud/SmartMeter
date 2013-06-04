using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace BusinessLayer.DAL
{
    public class BusinessContext: DbContext
    {
        public BusinessContext()
            : base("name=SmartMeterEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillingPeriod> BillingPeriods { get; set; }
        public DbSet<BillingRate> BillingRates { get; set; }
        public DbSet<BillingRateConfig> BillingRateConfigs { get; set; }
        public DbSet<BillScheme> BillSchemes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Command> Commands { get; set; }
        public DbSet<CommandValue> CommandValues { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<DeviceProperty> DeviceProperties { get; set; }
        public DbSet<DeviceType> DeviceTypes { get; set; }
        public DbSet<DeviceTypeProperty> DeviceTypeProperties { get; set; }
        public DbSet<LimitType> LimitTypes { get; set; }
        public DbSet<LoadScheme> LoadSchemes { get; set; }
        public DbSet<MeterProperty> MeterProperties { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<TimeScheme> TimeSchemes { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
