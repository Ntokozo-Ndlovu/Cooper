using Cooper.Data;
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


        public static  Data.Entity.Entity createEntity()
        {
            var changeTrack = _db.Entities.Add(new Data.Entity.Entity()
            {
                UUID = Guid.NewGuid()
            });
            _db.SaveChanges();

            return changeTrack.Entity;
        }
    }
}
