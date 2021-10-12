using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.Models
{
    public class FilterOptions
    {
        public string SearchItem { get; set; }
        public SortOrder Order { get; set; }
    }
}
