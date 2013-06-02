using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class DeviceTypeProperty
    {
        public int DeviceTypePropertyId { get; set; }
        public int DeviceTypeId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyParameter { get; set; }
        public string PropertyValue { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }

        public virtual DeviceType DeviceType { get; set; }
    }
}
