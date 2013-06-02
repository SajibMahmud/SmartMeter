using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class DeviceTypeProperty
    {
        public int DeviceTypePropertyId { get; set; }
        public int DeviceTypeId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyParameter { get; set; }
        public string PropertyValue { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual DeviceType DeviceType { get; set; }
    }
}
