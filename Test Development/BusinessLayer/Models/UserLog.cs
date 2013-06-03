using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class UserLog
    {
        public int UserLogId { get; set; }
        public int UserId { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime LogOutTime { get; set; }

        public virtual User User { get; set; }
    }
}
