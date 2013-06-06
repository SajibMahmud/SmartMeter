using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class Command
    {
        public Command()
        {
            this.CommandValues = new HashSet<CommandValue>();
        }
        public int CommandId { get; set; }
        public string CommandName { get; set; }

        public virtual ICollection<CommandValue> CommandValues { get; set; }
    }
}
