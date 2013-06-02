using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class CommandValue
    {
        public int CommandValueId { get; set; }
        public int DeviceTypeId { get; set; }
        public int CommandId { get; set; }
        public string Value { get; set; }

        public virtual Command Command { get; set; }
        public virtual DeviceType DeviceType { get; set; }
    }
}
