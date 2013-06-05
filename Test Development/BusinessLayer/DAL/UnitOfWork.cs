using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Models;

namespace BusinessLayer.DAL
{
    public class UnitOfWork : IDisposable
    {
        private BusinessContext context = new BusinessContext();
        private GenericRepository<Address> addressRepository;
        private GenericRepository<AppUser> appUserRepository;
        private GenericRepository<Bill> billRepository;
        private GenericRepository<BillingPeriod> billingPeriodRepository;
        private GenericRepository<BillingRate> billingRateRepository;
        private GenericRepository<BillingRateConfig> billingRateConfigRepository;
        private GenericRepository<BillScheme> billSchemeRepository;
        private GenericRepository<City> cityRepository;
        private GenericRepository<Command> commandRepository;
        private GenericRepository<CommandValue> commandValueRepository;
        private GenericRepository<Company> companyRepository;
        private GenericRepository<CompanyUser> companyUserRepository;
        private GenericRepository<Country> countryRepository;
        private GenericRepository<Device> deviceRepository;
        private GenericRepository<DeviceProperty> devicePropertyRepository;
        private GenericRepository<DeviceType> deviceTypeRepository;
        private GenericRepository<DeviceTypeProperty> deviceTypePropertyRepository;
        private GenericRepository<LimitType> limitTypeRepository;
        private GenericRepository<LoadScheme> loadSchemeRepository;
        private GenericRepository<MeterProperty> meterPropertyRepository;
        private GenericRepository<Permission> permissionRepository;
        private GenericRepository<Role> roleRepository;
        private GenericRepository<RolePermission> rolePermissionRepository;
        private GenericRepository<TimeScheme> timeSchemeRepository;
        private GenericRepository<UserLog> userLogRepository;
        private GenericRepository<UserPermission> userPermissionRepository;
        private GenericRepository<UserProfile> userProfileRepository;
        private GenericRepository<UserRole> userRoleRepository;

        public GenericRepository<Address> AddressRepository
        {
            get
            {

                if (this.addressRepository == null)
                {
                    this.addressRepository = new GenericRepository<Address>(context);
                }
                return addressRepository;
            }
        }

        public GenericRepository<AppUser> AppUserRepository
        {
            get
            {

                if (this.appUserRepository == null)
                {
                    this.appUserRepository = new GenericRepository<AppUser>(context);
                }
                return appUserRepository;
            }
        }


        public GenericRepository<Bill> BillRepository
        {
            get
            {

                if (this.billRepository == null)
                {
                    this.billRepository = new GenericRepository<Bill>(context);
                }
                return billRepository;
            }
        }

        public GenericRepository<BillingPeriod> BillingPeriodRepository
        {
            get
            {

                if (this.billingPeriodRepository == null)
                {
                    this.billingPeriodRepository = new GenericRepository<BillingPeriod>(context);
                }
                return billingPeriodRepository;
            }
        }

        public GenericRepository<BillingRate> BillingRateRepository
        {
            get
            {

                if (this.billingRateRepository == null)
                {
                    this.billingRateRepository = new GenericRepository<BillingRate>(context);
                }
                return BillingRateRepository;
            }
        }

        public GenericRepository<BillingRateConfig> BillingRateConfigRepository
        {
            get
            {

                if (this.billingRateConfigRepository == null)
                {
                    this.billingRateConfigRepository = new GenericRepository<BillingRateConfig>(context);
                }
                return billingRateConfigRepository;
            }
        }

        public GenericRepository<BillScheme> BillSchemeRepository
        {
            get
            {

                if (this.billSchemeRepository == null)
                {
                    this.billSchemeRepository = new GenericRepository<BillScheme>(context);
                }
                return billSchemeRepository;
            }
        }

        public GenericRepository<City> CityRepository
        {
            get
            {

                if (this.cityRepository == null)
                {
                    this.cityRepository = new GenericRepository<City>(context);
                }
                return cityRepository;
            }
        }

        public GenericRepository<Command> CommandRepository
        {
            get
            {

                if (this.commandRepository == null)
                {
                    this.commandRepository = new GenericRepository<Command>(context);
                }
                return commandRepository;
            }
        }

        public GenericRepository<CommandValue> CommandValueRepository
        {
            get
            {

                if (this.commandValueRepository == null)
                {
                    this.commandValueRepository = new GenericRepository<CommandValue>(context);
                }
                return commandValueRepository;
            }
        }

        public GenericRepository<Company> CompanyRepository
        {
            get
            {

                if (this.companyRepository == null)
                {
                    this.companyRepository = new GenericRepository<Company>(context);
                }
                return companyRepository;
            }
        }

        public GenericRepository<CompanyUser> CompanyUserRepository
        {
            get
            {

                if (this.companyUserRepository == null)
                {
                    this.companyUserRepository = new GenericRepository<CompanyUser>(context);
                }
                return companyUserRepository;
            }
        }

        public GenericRepository<Country> CountryRepository
        {
            get
            {

                if (this.countryRepository == null)
                {
                    this.countryRepository = new GenericRepository<Country>(context);
                }
                return countryRepository;
            }
        }

        public GenericRepository<Device> DeviceRepository
        {
            get
            {

                if (this.deviceRepository == null)
                {
                    this.deviceRepository = new GenericRepository<Device>(context);
                }
                return deviceRepository;
            }
        }

        public GenericRepository<DeviceProperty> DevicePropertyRepository
        {
            get
            {

                if (this.devicePropertyRepository == null)
                {
                    this.devicePropertyRepository = new GenericRepository<DeviceProperty>(context);
                }
                return devicePropertyRepository;
            }
        }

        public GenericRepository<DeviceType> DeviceTypeRepository
        {
            get
            {

                if (this.deviceTypeRepository == null)
                {
                    this.deviceTypeRepository = new GenericRepository<DeviceType>(context);
                }
                return deviceTypeRepository;
            }
        }

        public GenericRepository<DeviceTypeProperty> DeviceTypePropertyRepository
        {
            get
            {

                if (this.deviceTypePropertyRepository == null)
                {
                    this.deviceTypePropertyRepository = new GenericRepository<DeviceTypeProperty>(context);
                }
                return deviceTypePropertyRepository;
            }
        }

        public GenericRepository<LimitType> LimitTypeRepository
        {
            get
            {

                if (this.limitTypeRepository == null)
                {
                    this.limitTypeRepository = new GenericRepository<LimitType>(context);
                }
                return limitTypeRepository;
            }
        }

        public GenericRepository<LoadScheme> LoadSchemeRepository
        {
            get
            {

                if (this.loadSchemeRepository == null)
                {
                    this.loadSchemeRepository = new GenericRepository<LoadScheme>(context);
                }
                return loadSchemeRepository;
            }
        }

        public GenericRepository<MeterProperty> MeterPropertyRepository
        {
            get
            {

                if (this.meterPropertyRepository == null)
                {
                    this.meterPropertyRepository = new GenericRepository<MeterProperty>(context);
                }
                return meterPropertyRepository;
            }
        }

        public GenericRepository<Permission> PermissionRepository
        {
            get
            {

                if (this.permissionRepository == null)
                {
                    this.permissionRepository = new GenericRepository<Permission>(context);
                }
                return permissionRepository;
            }
        }

        public GenericRepository<Role> RoleRepository
        {
            get
            {

                if (this.roleRepository == null)
                {
                    this.roleRepository = new GenericRepository<Role>(context);
                }
                return roleRepository;
            }
        }

        public GenericRepository<RolePermission> RolePermissionRepository
        {
            get
            {

                if (this.rolePermissionRepository == null)
                {
                    this.rolePermissionRepository = new GenericRepository<RolePermission>(context);
                }
                return rolePermissionRepository;
            }
        }

        public GenericRepository<TimeScheme> TimeSchemeRepository
        {
            get
            {

                if (this.timeSchemeRepository == null)
                {
                    this.timeSchemeRepository = new GenericRepository<TimeScheme>(context);
                }
                return timeSchemeRepository;
            }
        }

        public GenericRepository<UserLog> UserLogRepository
        {
            get
            {

                if (this.userLogRepository == null)
                {
                    this.userLogRepository = new GenericRepository<UserLog>(context);
                }
                return userLogRepository;
            }
        }

        public GenericRepository<UserPermission> UserPermissionRepository
        {
            get
            {

                if (this.userPermissionRepository == null)
                {
                    this.userPermissionRepository = new GenericRepository<UserPermission>(context);
                }
                return userPermissionRepository;
            }
        }

        public GenericRepository<UserProfile> UserProfileRepository
        {
            get
            {

                if (this.userProfileRepository == null)
                {
                    this.userProfileRepository = new GenericRepository<UserProfile>(context);
                }
                return userProfileRepository;
            }
        }

        public GenericRepository<UserRole> UserRoleRepository
        {
            get
            {

                if (this.userRoleRepository == null)
                {
                    this.userRoleRepository = new GenericRepository<UserRole>(context);
                }
                return userRoleRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
