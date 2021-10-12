using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Domain
{
    public class ResortFacility : BaseEntity
    {
        public long ResortId { get; set; }
        public Resort Resort { get; set; }
        public long FacilityId { get; set; }
        public Facility Facility { get; set; }
    }
}
