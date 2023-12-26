using Cooper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class Address:DomainBase
    {
        public Address(CooperDbContext db) : base(db)
        {

        }
        public static void createAddress(Address address)
        {
            
        }

    }
}
