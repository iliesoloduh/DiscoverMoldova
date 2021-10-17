using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.Dtos
{
    public class LocationDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long DistrictId { get; set; }
    }
}
