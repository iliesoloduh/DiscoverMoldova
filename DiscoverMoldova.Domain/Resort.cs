using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Domain
{
    public class Resort : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Price { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }
        public long LocationId { get; set; }
        public Location Location { get; set; }
        public List<ResortFacility> ResortFacilities { get; set; }
    }
}
