using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class MeterProperty
    {
        public int DeviceId { get; set; }
        public int MeterPropertyId { get; set; }
        public double Voltage { get; set; }
        public double RealPower { get; set; }
        public double PowerFactor { get; set; }
        public double KWHR { get; set; }
        public System.DateTime TransmissionTime { get; set; }
        public Nullable<System.DateTime> LoggedAt { get; set; }
        public bool IsLatest { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public System.DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser AppUser { get; set; }
        public virtual AppUser AppUser1 { get; set; }
        public virtual Device Device { get; set; }
    }
}
