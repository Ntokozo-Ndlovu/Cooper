using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Password
    {
        public int Id { get; set; }
        public string PasswordKey { get; set; }
        public int EntityId { get; set; }
        public int UserId { get; set; }

    }
}
