using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DiscoverMoldova.Core.Exceptions
{
    public class ApiException : Exception
    {
        public HttpStatusCode Code { get; }
        public ApiException(HttpStatusCode code, string message) : base(message)
        {
            Code = code;
        }
    }
}
