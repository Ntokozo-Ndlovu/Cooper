using Cooper.Data;
using Cooper.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class Challenge
    {

        private static CooperDbContext _db;
        public Challenge(CooperDbContext context) {
            _db = context; 
        }



        public static Data.Entity.Challenge Add(Data.Entity.Challenge challenge)
        {
            var entity = Entity.CreateEntity() ?? throw new Exception("Entity Not Created");
            challenge.EntityId = entity.Id;
            var createdChallenge = _db.Add(challenge);
            _db.SaveChanges();
            return createdChallenge.Entity;

        }

        public static Data.Entity.Challenge FindChallengeById(Guid challengeId)
        {
            var entity = Entity.FindEntityById(challengeId);
            var tempChallenge = _db.Challenge.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Challenge Not Found");
            return tempChallenge;
        }

        public static List<Data.Entity.Challenge> GetAllChallenges()
        {
            return _db.Challenge.ToList();
        }
        public static Data.Entity.Challenge DeleteChallengeById(Guid challengeId)
        {
            var entity = Entity.FindEntityById(challengeId);
            var tempChallenge = _db.Challenge.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception ("Challenge Not Found");
            Entity.DeleteEntity(entity);
            _db.Challenge.Remove(tempChallenge);
            _db.SaveChanges();
            return tempChallenge;
        }

        public static Data.Entity.Challenge DeleteChallenge(Data.Entity.Challenge challenge)
        {
            _db.Challenge.Remove(challenge);
            _db.SaveChanges();
            return challenge;
        }

        public static Data.Entity.Challenge UpdateChallenge(Data.Entity.Challenge challenge)
        {
            var tempChallenge = _db.Challenge.FirstOrDefault(x=> x.Id == challenge.Id) ?? throw new Exception("Challenge Not Found");
            tempChallenge.Description = challenge.Description;
            tempChallenge.Name = challenge.Name;
            tempChallenge.StartDate = challenge.StartDate;
            tempChallenge.EndDate = challenge.EndDate;
            tempChallenge.Price = challenge.Price;  
            _db.Challenge.Update(tempChallenge);
            _db.SaveChanges();

            return tempChallenge;
        }
    }
}
