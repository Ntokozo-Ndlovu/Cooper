using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Address
    {
        public int Id { get; set; }
        public string StreetName {  get; set; }
        public string Suburb {  get; set; }
        public string City { get; set; }
        public string PostalCode {  get; set; }
        public int EntityId { get; set; }

    }
}
