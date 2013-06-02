using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class City
    {
        //public City()
        //{
        //    this.Addresses = new HashSet<Address>();
        //}

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual Country Country { get; set; }
    }
}
