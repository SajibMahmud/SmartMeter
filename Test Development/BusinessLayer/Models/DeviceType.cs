using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class DeviceType
    {
        public int DeviceTypeId { get; set; }
        public string DeviceTypeName { get; set; }
        public string DeviceTypeDecription { get; set; }

        public virtual ICollection<CommandValue> CommandValues { get; set; }
        public virtual ICollection<Device> Devices { get; set; }
        public virtual ICollection<DeviceTypeProperty> DeviceTypeProperties { get; set; }
    }
}
