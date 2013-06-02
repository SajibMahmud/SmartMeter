using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Address
    {
        //public Address()
        //{
        //    this.Companies = new HashSet<Company>();
        //    this.UserProfiles = new HashSet<UserProfile>();
        //}

        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string CellPhone { get; set; }
        public string ZipCode { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CretaedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
