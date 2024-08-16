namespace Cooper.API.Service.Extensions
{
    public static class ContactExtension
    {
        public static Common.Contact DTO(this Domain.Contact contact)
        {
            return new Common.Contact()
            {
                Email = contact.Email,
                PhoneNumber = contact.PhoneNumber
            };

        }

    }
}
