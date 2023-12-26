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
        private CooperDbContext _db;
        public DomainBase(CooperDbContext cooperDbContext) { 
            this._db = cooperDbContext;
        }

    }
}
