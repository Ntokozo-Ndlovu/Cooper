using Cooper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class DomainBase
    {
        protected static CooperDbContext _db;
        public DomainBase(CooperDbContext cooperDbContext) { 
            _db = cooperDbContext;
        }

        protected DomainBase() { }

    }
}
