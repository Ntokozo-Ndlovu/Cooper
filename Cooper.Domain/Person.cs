using Cooper.Data;

namespace Cooper.Domain
{
    public class Person
    {

        private Person(Data.Entity.Person person)
        {
            this.Id = person.Id;
            this.Name = person.Name;
            this.Surname = person.Surname;
            this.Age = person.Age;
            this.Gender = person.Gender;
        }

        public static Person Create(string name, string surname, int age, string gender, CooperDbContext _db)
        {
            var person = new Data.Entity.Person()
            {
                Name = name,
                Surname = surname,
                Age = age,
                Gender = gender
            };
            _db.Person.Add(person);
            _db.SaveChanges();
            return new Person(person);
        }

        public static Person FindById(int id, CooperDbContext _db)
        {
            var person = _db.Person.FirstOrDefault(person => person.Id == id) ?? throw new Exception("Person Not Found");
            return new Person(person);
        }

        public static Person RemoveById(int id, CooperDbContext _db)
        {
            var person = _db.Person.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Person Not Found");
            _db.Person.Remove(person);
            _db.SaveChanges();

            return new Person(person);
        }

        public static Person UpdatePerson(int id, CooperDbContext _db, string name="" , string surname="" , int age=0, string gender="")
        {
            var person = _db.Person.FirstOrDefault(person => person.Id == id) ?? throw new Exception("Person not Found");
            if(name != "")
                person.Name = name;
            if(surname != "")
                person.Surname = surname;
            if(age > 0)
                person.Age = age;
            if(gender != "")
                person.Gender = gender;

            _db.Person.Update(person);
            _db.SaveChanges();
            return new Person(person);
        }

        public long Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Gender { get; }
    }
}
