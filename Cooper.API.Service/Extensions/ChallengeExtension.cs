using Cooper.API.Common;

namespace Cooper.API.Service.Extensions
{
    public static class ChallengeExtenstion
    {
        public static Common.Challenge DTO(this Domain.Challenge challenge)
        {
            return new Common.Challenge()
            {
                Name = challenge.Name,
                Description = challenge.Description,
                Title = challenge.Name,
                StartDate = challenge.StartDate,
                EndDate = challenge.EndDate,
                Price = challenge.Price
            };

        }

        public static List<Common.Challenge> DTO(this List<Domain.Challenge> challengeList){

            return challengeList.Select((challenge)=> challenge.DTO()).ToList();
        }



    }
}
