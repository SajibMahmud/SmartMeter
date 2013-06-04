using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public  class UserPermission
    {
        public int UserPermissionId { get; set; }
        public int PermissionId { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
        public virtual Permission Permission { get; set; }
    }
}
