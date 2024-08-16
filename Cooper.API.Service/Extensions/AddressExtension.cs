namespace Cooper.API.Service.Extensions
{
    public static class AddressExtension
    {
        public static Common.Address DTO(this Domain.Address address)
        {

            return new Common.Address()
            {
                StreetName = address.StreetName,
                Suburb = address.Suburb,
                City = address.City,
                PostalCode = address.PostalCode

            };
        }

    }

}
