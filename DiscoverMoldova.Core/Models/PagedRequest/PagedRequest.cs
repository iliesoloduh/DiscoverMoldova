using System;
using System.Collections.Generic;
using System.Text;

namespace DiscoverMoldova.Core.Models.PagedRequest
{
    public class PagedRequest
    {
        public PagedRequest()
        {
            RequestFilters = new RequestFilters();
        }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public string ColumnNameForSorting { get; set; }
        public string SortDirection { get; set; }
        public RequestFilters RequestFilters { get; set; }
    }
}
