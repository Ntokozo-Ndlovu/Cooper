using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Like
    {
        public int Id { get; set; }
        public int PostId {  get; set; }
        public int UserId {  get; set; }

        public int EntityId { get; set; }

    }
}
