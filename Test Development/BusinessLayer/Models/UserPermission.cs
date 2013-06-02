using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public  class UserPermission
    {
        public int UserPermissionId { get; set; }
        public int PermissionId { get; set; }
        public int AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
