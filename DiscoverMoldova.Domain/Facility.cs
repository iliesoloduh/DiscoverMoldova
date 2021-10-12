using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Domain
{
    public class Facility : BaseEntity
    {
        public string Name { get; set; }
        public List<ResortFacility> ResortFacilities { get; set; }
    }
}
