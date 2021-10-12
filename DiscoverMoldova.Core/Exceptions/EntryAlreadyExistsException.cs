using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DiscoverMoldova.Core.Exceptions
{
    public class EntryAlreadyExistsException : ApiException
    {
        public EntryAlreadyExistsException(string message) : base(HttpStatusCode.BadRequest, message)
        {
        }
    }
}
