using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.API.Common
{
    public class ResponseBase
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Message { get; set; }
    }
}
