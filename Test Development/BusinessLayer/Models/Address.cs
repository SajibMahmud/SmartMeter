using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Address
    {
        public Address()
        {
            this.Companies = new HashSet<Company>();
            this.UserProfiles = new HashSet<UserProfile>();
        }
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string CellPhone { get; set; }
        public string ZipCode { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }


        public virtual AppUser Creator { get; set; }
        public virtual AppUser Updator { get; set; }
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<UserProfile> UserProfiles { get; set; }
    }
}
