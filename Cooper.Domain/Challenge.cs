using Cooper.Data;

namespace Cooper.Domain
{
    public class Challenge
    {
        private Challenge(Data.Entity.Challenge challenge)
        {
            this.Name = challenge.Name;
            this.Price = challenge.Price;
            this.StartDate = challenge.StartDate;
            this.EndDate = challenge.EndDate;
            this.Description = challenge.Description;
            this.ChallengeGUID = challenge.ChallengeGuid;
        }

        public static Challenge Create(string name, string description, DateTime startDate, DateTime endDate, float price, CooperDbContext _db)
        {
            var newChallengeEntity = new Data.Entity.Challenge()
            {
                Name = name,
                Description = description,
                StartDate = startDate,
                EndDate = endDate,
                Price = price,
                ChallengeGuid = Guid.NewGuid()
            };

            _db.Challenge.Add(newChallengeEntity);
            _db.SaveChanges();
            return new Challenge(newChallengeEntity);
        }

        public static Challenge FindById(Guid challengeId, CooperDbContext _db)
        {
            var challenge = _db.Challenge.FirstOrDefault(challenge => challenge.ChallengeGuid.Equals(challengeId));
            if(challenge == null) 
                throw new Exception("Challenge no found");
            return new Challenge(challenge);
        }

        public static List<Challenge> FindAll(CooperDbContext _db)
        {
            var challenges = _db.Challenge.Select(challenge => new Challenge(challenge)).ToList();
            return challenges;
        }

        public static Challenge RemoveChallengeById(Guid challengeId, CooperDbContext _db)
        {
            var challenge = _db.Challenge.FirstOrDefault(challenge => challenge.ChallengeGuid == challengeId);
            if(challenge == null)
                throw new Exception("Challenge not found");
            _db.Challenge.Remove(challenge);
            _db.SaveChanges();
             return new Challenge(challenge);
        }

        public static Challenge UpdateChallenge(Guid challengeId,CooperDbContext _db,string name = "", string description="",
                DateTime? startDate = null, DateTime? endDate = null ,float price = 0)
        {

            var challenge = _db.Challenge.FirstOrDefault(challenge => challenge.ChallengeGuid == challengeId) ?? throw new Exception("Challenge Not Found");
            if(description != "")
            challenge.Description = challenge.Description;
            if(name != "")
            challenge.Name = challenge.Name;
            if(startDate != null)
            challenge.StartDate = challenge.StartDate;
            if(endDate != null)
            challenge.EndDate = challenge.EndDate;
            if(price > 0)
            challenge.Price = challenge.Price;
            _db.Challenge.Update(challenge);
            _db.SaveChanges();
                    
            return new Challenge(challenge);
        }

        public string Description { get; }
        public string Name { get; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public float Price { get; }
        public Guid ChallengeGUID {get;}
    }
}
