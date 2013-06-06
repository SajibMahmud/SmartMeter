using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public partial class Device
    {
        public int DeviceId { get; set; }
        public int DeviceTypeId { get; set; }
        public string HardwareId { get; set; }
        public DateTime? ProductionDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public int? ParentDeviceId { get; set; }
        public int? NumberOfSubDevice { get; set; }
        public bool Status { get; set; }
        public int BillSchemeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }

        public virtual AppUser User { get; set; }
        public virtual AppUser Creator { get; set; }
        public virtual AppUser Updator { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual BillScheme BillScheme { get; set; }
        public virtual DeviceType DeviceType { get; set; }
        public virtual ICollection<Device> Device1 { get; set; }
        public virtual Device Device2 { get; set; }
        public virtual ICollection<DeviceProperty> DeviceProperties { get; set; }
        public virtual ICollection<MeterProperty> MeterProperties { get; set; }
    }
}
