using Cooper.API.Response.Challenge;

namespace Cooper.API.Service.Extensions
{
    public static class ChallengeExtenstion
    {
        public static FindChallengeResponse ToApiModel(this Domain.Challenge challenge)
        {
            return new FindChallengeResponse()
            {
            Id = challenge.ChallengeGUID,
            Title= challenge.Name,
            Description = challenge.Description,
            StartDate = challenge.StartDate,
            EndDate = challenge.EndDate,
            Price = challenge.Price
    };
        }
    }
}
