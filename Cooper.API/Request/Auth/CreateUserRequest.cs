using Cooper.API.Common;

namespace Cooper.API.Request.Auth
{
    public class CreateUserRequest
    {
        public string UserName { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public Person Person { get; set; }
        public UserPassword Password { get; set; }

    }
}
