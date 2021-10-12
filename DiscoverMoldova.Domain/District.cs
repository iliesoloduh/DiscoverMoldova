using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Domain
{
    public class District : BaseEntity
    {
        public string Name { get; set; }
        public List<Location> Locations { get; set; }
    }
}
