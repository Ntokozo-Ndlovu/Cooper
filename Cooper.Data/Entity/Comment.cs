using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; } 
        public int EntityId {  get; set; }

        public int Entity {  get; set; }
    }
}
