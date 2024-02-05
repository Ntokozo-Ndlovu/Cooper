using Cooper.Data;

namespace Cooper.Domain
{
    public class Person
    {
        private static CooperDbContext _db = new CooperDbContext();
      

        private Person(Data.Entity.Person person)
        {
            this.Id = person.Id;
            this.Name = person.Name;
            this.Surname = person.Surname;
            this.Age = person.Age;
            this.Gender = person.Gender;
            this.EntityId = person.EntityId;
        }

        public static Person Create(Data.Entity.Person person)
        {
            var entity = Entity.CreateEntity();
            person.EntityId = entity.Id;
            _db.Person.Add(person);
            _db.SaveChanges();
            return new Person(person);
        }

        public static Person FindPersonById(Guid guid)
        {
            var entity = Entity.FindEntityById(guid);
            var person = _db.Person.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Person Not Found");
            return new Person(person);
        }

        public static Person FindPersonById(int id) { 
            var entity = _db.Person.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Person Not Found");
            return new Person(entity);
        }

        public static Person RemovePersonById(Guid guid)
        {
            var entity = Entity.FindEntityById(guid);
            var person = _db.Person.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Person Not Found");
            _db.Person.Remove(person);
            _db.SaveChanges();

            return new Person(person);
        }

        public static Person RemovePerson(Data.Entity.Person person)
        {
            var result = _db.Person.Remove(person);
            _db.SaveChanges();
            return new Person(result.Entity);
        }

        public static Person UpdatePerson(Data.Entity.Person person)
        {
            var result = _db.Person.Update(person);
            _db.SaveChanges();
            return new Person(result.Entity);
        }

        public int Id { get;  }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }
        public string Gender { get; }
        public int EntityId { get; }
    }
}
