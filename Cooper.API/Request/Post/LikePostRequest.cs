using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.API.Request.Post
{
    public class LikePostRequest
    {
        public Guid UserId { get; set; }
        public Guid PostId { get; set; }

    }
}
