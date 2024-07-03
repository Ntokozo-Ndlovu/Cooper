using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    
        public int PersonId {  get; set; }
        public int AddressId { get; set; }
        public int ContactId { get; set; }

        public int EntityId { get; set; }
    }
}
