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

    public class UserPassword
    {
        public string Password { get; set; }
    }

    public class Address
    {
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }


    }
    public class Contact
    {

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

    }
    public class Person
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }

    }

}
