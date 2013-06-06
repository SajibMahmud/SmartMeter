using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace BusinessLayer.DAL
{
    public class BusinessContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //createdby and updated by relations
            modelBuilder.Entity<Address>().HasRequired(x => x.Creator).WithMany(x => x.CreatedAddresses).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Address>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedAddresses).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Bill>().HasRequired(x => x.Creator).WithMany(x => x.CreatedBills).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Bill>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedBills).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<BillingPeriod>().HasRequired(x => x.Creator).WithMany(x => x.CreatedBillingPeriods).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<BillingPeriod>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedBillingPeriods).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<BillingRateConfig>().HasRequired(x => x.Creator).WithMany(x => x.CreatedBillingRateConfigs).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<BillingRateConfig>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedBillingRateConfigs).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<BillingRate>().HasRequired(x => x.Creator).WithMany(x => x.CreatedBillingRates).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<BillingRate>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedBillingRates).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Company>().HasRequired(x => x.Creator).WithMany(x => x.CreatedCompanies).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Company>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedCompanies).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<CompanyUser>().HasRequired(x => x.Creator).WithMany(x => x.CreatedCompanyUsers).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<CompanyUser>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedCompanyUsers).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Device>().HasRequired(x => x.Creator).WithMany(x => x.CreatedDevices).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<Device>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedDevices).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<LimitType>().HasRequired(x => x.Creator).WithMany(x => x.CreatedLimitTypes).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<LimitType>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedLimitTypes).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<MeterProperty>().HasRequired(x => x.Creator).WithMany(x => x.CreatedMeterProperties).HasForeignKey(x => x.CreatedBy).WillCascadeOnDelete(false);
            modelBuilder.Entity<MeterProperty>().HasRequired(x => x.Updator).WithMany(x => x.UpdatedMeterProperties).HasForeignKey(x => x.UpdatedBy).WillCascadeOnDelete(false);

            // Other relations
            modelBuilder.Entity<CompanyUser>().HasRequired(x => x.User).WithMany(x => x.CompanyUsers).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<Device>().HasRequired(x => x.User).WithMany(x => x.Devices).HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserPermission>().HasRequired(x => x.User).WithMany(x => x.UserPermissions).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserProfile>().HasKey(x => x.UserId);
            modelBuilder.Entity<UserProfile>().HasRequired(x => x.User).WithOptional(x => x.UserProfile);
            modelBuilder.Entity<UserRole>().HasRequired(x => x.User).WithMany(x => x.UserRoles).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserLog>().HasKey(x => new { x.UserId, x.LogInTime});
            modelBuilder.Entity<UserLog>().HasRequired(x => x.User).WithMany(x => x.UserLogs).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<Address>().HasRequired(x => x.Country).WithMany(x => x.Addresses).HasForeignKey(x => x.CountryId).WillCascadeOnDelete(false);
            modelBuilder.Entity<Address>().HasRequired(x => x.City).WithMany(x => x.Addresses).HasForeignKey(x => x.CityId).WillCascadeOnDelete(false);
            modelBuilder.Entity<City>().HasRequired(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId);
            //modelBuilder.Entity<City>().HasRequired(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId);
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
