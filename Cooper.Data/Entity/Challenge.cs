using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Challenge
    {
        public int Id { get; set; }
        public Guid ChallengeGuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public int EntityId { get; set; }


    }
}
