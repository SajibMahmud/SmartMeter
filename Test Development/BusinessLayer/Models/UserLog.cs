using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class UserLog
    {
        public int UserId { get; set; }
        public System.DateTime LogInTime { get; set; }
        public Nullable<System.DateTime> LogOutTime { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
