using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DiscoverMoldova.Core.Exceptions
{
    public class NotFoundException : ApiException
    {
        public NotFoundException(string message) : base(HttpStatusCode.NotFound, message)
        {
        }
    }
}
