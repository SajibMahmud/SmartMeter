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
        public DateTime LogInTime { get; set; }
        public DateTime LogOutTime { get; set; }

        public virtual AppUser AppUser { get; set; }
    }
}
