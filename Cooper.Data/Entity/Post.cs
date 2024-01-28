using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Data.Entity
{
    public class Post
    {
        public int Id { get; set; }
        public string Description {  get; set; }
        public string Title { get; set; }
        public int Likes {get; set; }
        public int EntityId {  get; set; }
        public Guid ChallengeId { get; set; }
    }
}
