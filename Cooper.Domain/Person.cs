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
            this.EntityId = person.EntityId;
        }

        public static Person Create(Data.Entity.Person person, CooperDbContext _db)
        {
            var entity = Entity.CreateEntity(_db);
            person.EntityId = entity.Id;
            _db.Person.Add(person);
            _db.SaveChanges();
            return new Person(person);
        }

        public static Person FindPersonById(Guid guid, CooperDbContext _db)
        {
            var entity = Entity.FindEntityById(guid,_db);
            var person = _db.Person.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Person Not Found");
            return new Person(person);
        }

        public static Person FindPersonById(int id, CooperDbContext _db) { 
            var entity = _db.Person.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Person Not Found");
            return new Person(entity);
        }

        public static Person RemovePersonById(Guid guid, CooperDbContext _db)
        {
            var entity = Entity.FindEntityById(guid,_db);
            var person = _db.Person.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Person Not Found");
            _db.Person.Remove(person);
            _db.SaveChanges();

            return new Person(person);
        }

        public static Person RemovePerson(Data.Entity.Person person, CooperDbContext _db)
        {
            var result = _db.Person.Remove(person);
            _db.SaveChanges();
            return new Person(result.Entity);
        }

        public static Person UpdatePerson(Data.Entity.Person person, CooperDbContext _db)
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
