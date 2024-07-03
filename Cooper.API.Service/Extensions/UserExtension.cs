
using System.Runtime.CompilerServices;
using Cooper.API.Common;
using Cooper.API.Request.Auth;
using Cooper.API.Response.Auth;
using Cooper.API.Response.User;
using Cooper.Domain;

namespace Cooper.API.Service.Extensions
{

    public static class UserExtenstions
    {

        public static Data.Entity.Address ToAddressEntity(this Common.Address address)
        {
            return new Data.Entity.Address()
            {
                StreetName = address.StreetName,
                City = address.City,
                PostalCode = address.PostalCode,
                Suburb = address.Suburb
            };
        }

        public static Data.Entity.Contact ToContactEntity(this Common.Contact contact)
        {
            return new Data.Entity.Contact()
            {
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber,
            };
        }

        public static Data.Entity.Person ToPersonEntity(this Common.Person person) {
            return new Data.Entity.Person()
            {
                Name = person.Name,
                Surname = person.Surname,
                Age = person.Age,
                Gender = person.Gender,
            };
        }

        public static Data.Entity.Password ToPasswordEntity(this UserPassword userPassword)
        {
            return new Data.Entity.Password()
            {
                PasswordKey = userPassword.Password
            };
        }
        public static LoginResponse ToApiModel(this LoginResponse response)
        {
            return response;
        }

        public static CreateUserResponse ToApiModel(this Domain.User user)
        {
            return new CreateUserResponse()
            {
                UserID = user.UserUUID
            };
        }

        public static CreateUserResponse ToApiModel(this CreateUserResponse response)
        {
            return response;
        }

        public static GetUserResponse ToApiModel(this Domain.User user,Domain.Address address, Domain.Contact contact, Domain.Person person)
        {
            return new GetUserResponse(){
                Username = user.UserName,
                Address = new Common.Address()
                {
                    StreetName = address.StreetName,
                    Suburb = address.Suburb,
                    City = address.City,
                    PostalCode = address.PostalCode,

                },
             
                Contact = new Common.Contact()
                {
                    Email = contact.Email,
                    PhoneNumber = contact.PhoneNumber,
                },
                Person = new Common.Person()
                {
                    Age = person.Age,
                    Name= person.Name,
                    Gender = person.Gender,
                    Surname = person.Surname,
                }
            };
        }

    }
}