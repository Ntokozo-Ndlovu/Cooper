using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Media
    {
        public int Id { get; set; }
        public Guid MediaGuid { get; set; }
        public int MediaType {  get; set; }
        public string Link {  get; set; }
        public int EntityId { get; set; }
        public int Entity {  get; set; }
    }
}
