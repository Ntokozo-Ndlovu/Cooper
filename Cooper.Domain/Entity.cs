using Cooper.Data;
using Cooper.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cooper.Domain
{
    public class Entity:DomainBase
    {
        static CooperDbContext db = new CooperDbContext();
        public Entity(Guid id) {
            
            var entity = FindEntityById(id);
            Id = entity.Id;
            UUID = entity.UUID;
        }

        public Entity(int id)
        {
            var entity = FindEntityById(id);
            Id = entity.Id;
            UUID = entity.UUID;
        }

        public static Data.Entity.Entity CreateEntity()
        {
            var changeTrack = db.Entities.Add(new Data.Entity.Entity()
            {
                UUID = Guid.NewGuid()
            });
            db.SaveChanges();

            return changeTrack.Entity;
        }

        public static Data.Entity.Entity DeleteEntity(Data.Entity.Entity entity)
        {
            db.Entities.Remove(entity);
            db.SaveChanges();
            return entity;
        }


        public static Data.Entity.Entity FindEntityById(Guid id)
        {
            var entity = db.Entities.FirstOrDefault(x =>  x.UUID == id)?? throw new Exception("Entity not found");
            return entity;
        }

        public static Data.Entity.Entity FindEntityById(int id)
        {
            var entity =  db.Entities.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Entity not found");
            return entity;
        }

        public int Id { get; }
        public Guid UUID { get; }
    }
}
