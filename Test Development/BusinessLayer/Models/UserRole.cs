using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class UserRole
    {
        public int UserRoleId { get; set; }
        public int AppUserId { get; set; }
        public int RoleId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Role Role { get; set; }
    }
}
