using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class UserProfile
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public int AddressId { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string SocialSecurityNumber { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

        public virtual Address Address { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
