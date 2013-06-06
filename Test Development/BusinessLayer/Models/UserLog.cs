using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class UserLog
    {
        [Key, Column(Order=0)]
        public int UserId { get; set; }
        [Key, Column(Order = 1)]
        public DateTime LogInTime { get; set; }
        public DateTime LogOutTime { get; set; }

        public virtual AppUser User { get; set; }
    }
}
