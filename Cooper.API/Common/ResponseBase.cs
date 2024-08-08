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
        public ResponseBase(HttpStatusCode status, string description){
                this.Status = status;
                this.Description = description;
        }
        public HttpStatusCode Status{ get; set; }
        public string Description { get; set; }
    }
}
