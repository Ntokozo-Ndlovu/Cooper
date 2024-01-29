
using System.Runtime.CompilerServices;
using Cooper.API.Request.User;
using Cooper.API.Response.User;

namespace Cooper.API.Service.Extensions
{

    public static class UserExtenstions
    {

        public static Data.Entity.Address ToAddressEntity(this Address address)
        {
            return new Data.Entity.Address()
            {
                StreetName = address.StreetName,
                City = address.City,
                PostalCode = address.PostalCode,
                Suburb = address.Suburb
            };
        }

        public static Data.Entity.Contact ToContactEntity(this Contact contact)
        {
            return new Data.Entity.Contact()
            {
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber,
            };
        }

        public static Data.Entity.Person ToPersonEntity(this Person person) {
            return new Data.Entity.Person()
            {
                Name = person.Name,
                Surname = person.Surname,
                Age = person.Age,
                Gender = person.Gender,
            };
        }

        public static CreateUserResponse ToApiModel(this Domain.User user)
        {
            return new CreateUserResponse()
            {
                UserID = user.UserUUID
            };
        }

    }
}