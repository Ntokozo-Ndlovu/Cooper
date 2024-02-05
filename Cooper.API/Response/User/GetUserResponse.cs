using Cooper.API.Common;

namespace Cooper.API.Response.User
{
    public class GetUserResponse
    {
        public string UserName { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public Person Person { get; set; }
    }
}
