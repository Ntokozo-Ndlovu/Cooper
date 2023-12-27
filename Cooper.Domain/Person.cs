using Cooper.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class Person
    {
        private static CooperDbContext _db;
        public Person(CooperDbContext context) {
            _db = context;
        }


        public Data.Entity.Person Add(Data.Entity.Person person)
        {
            var entity = Entity.CreateEntity();
            person.EntityId = entity.Id;
            _db.Person.Add(person);
            _db.SaveChanges();
            return person;
        }

        public Data.Entity.Person FindPersonById(Guid guid)
        {
            var entity = Entity.FindEntityById(guid);
            var person = _db.Person.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Person Not Found");
            return person;
        }

        public Data.Entity.Person RemovePersonById(Guid guid)
        {
            var entity = Entity.FindEntityById(guid);
            var person = _db.Person.FirstOrDefault(x => x.EntityId == entity.Id) ?? throw new Exception("Person Not Found");
            _db.Person.Remove(person);
            _db.SaveChanges();

            return person;
        }

        public Data.Entity.Person RemovePerson(Data.Entity.Person person)
        {
            var result = _db.Person.Remove(person);
            _db.SaveChanges();
            return result.Entity;
        }

        public Data.Entity.Person UpdatePerson(Data.Entity.Person person)
        {
            var result = _db.Person.Update(person);
            _db.SaveChanges();
            return result.Entity;
        }

    }
}
