using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public DateTime TransmissionTime { get; set; }
        public DateTime? LoggedAt { get; set; }
        public bool IsLatest { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        public virtual Device Device { get; set; }
    }
}
