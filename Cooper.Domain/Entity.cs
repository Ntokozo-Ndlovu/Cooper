using Cooper.Data;
using Cooper.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class Entity
    {
        public static CooperDbContext _db;
        public Entity(CooperDbContext context)
        {
            _db = context;
        }


        public static  Data.Entity.Entity CreateEntity()
        {
            var changeTrack = _db.Entities.Add(new Data.Entity.Entity()
            {
                UUID = Guid.NewGuid()
            });
            _db.SaveChanges();

            return changeTrack.Entity;
        }

        public static Data.Entity.Entity DeleteEntity(Data.Entity.Entity entity)
        {
            _db.Entities.Remove(entity);
            _db.SaveChanges();
            return entity;
        }


        public static Data.Entity.Entity FindEntityById(Guid id)
        {
            var entity = _db.Entities.FirstOrDefault(x =>  x.UUID == id)?? throw new Exception("Entity not found");
            return entity;
        }
    }
}
