using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Domain
{
    public class Location : BaseEntity
    {
        public string Name { get; set; }
        public long DistrictId { get; set; }
        public District District { get; set; }
        public List<Resort> Resorts { get; set; }
    }
}
