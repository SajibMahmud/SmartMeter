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
        [Key]
        public int UserId { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime LogOutTime { get; set; }

        [ForeignKey("UserId")]
        public virtual AppUser User { get; set; }
    }
}
