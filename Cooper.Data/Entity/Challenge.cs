using System;
using System.Collections.Generic;
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

    }
}
