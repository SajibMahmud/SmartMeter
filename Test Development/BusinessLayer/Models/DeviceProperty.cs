using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class DeviceProperty
    {
        public int DevicePropertyId { get; set; }
        public int DeviceId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyParameter { get; set; }
        public string PropertyValue { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

        public virtual Device Device { get; set; }
    }
}
