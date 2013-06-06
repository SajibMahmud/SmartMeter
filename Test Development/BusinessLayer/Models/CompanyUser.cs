using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class CompanyUser
    {
        [Key, Column(Order = 0)]
        public int CompanyId { get; set; }
        [Key, Column(Order = 1)]
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser User { get; set; }
        public virtual AppUser Creator { get; set; }
        public virtual AppUser Updator { get; set; }
        public virtual Company Company { get; set; }
    }
}
