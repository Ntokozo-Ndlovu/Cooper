using Cooper.API.Common;
using Cooper.API.Response.Auth;
using Cooper.API.Response.User;
using Cooper.Domain;
using System.Net;

namespace Cooper.API.Service.Extensions
{

    public static class UserExtenstions
    {

       public static Common.User DTO(this Domain.User user, Domain.Address address, Domain.Contact contact, Domain.Person person)
        {

            return new Common.User()
            {
                Username = user.UserName,
                Contact = contact.DTO(),
                Address = address.DTO(),
                Person = person.DTO()
            };

        }

    }
}
