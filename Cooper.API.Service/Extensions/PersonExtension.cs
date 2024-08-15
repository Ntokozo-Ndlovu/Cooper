namespace Cooper.API.Service.Extensions
{
    public static class PersonExtension
    {
        public static Common.Person DTO(this Domain.Person person)
        {

            return new Common.Person()
            {
                Name = person.Name,
                Surname = person.Surname,
                Age = person.Age,
                Gender = person.Gender
            };

        }


    }
}
