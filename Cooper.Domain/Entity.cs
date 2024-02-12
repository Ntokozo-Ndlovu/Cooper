using Cooper.Data;


namespace Cooper.Domain
{
    public class Entity:DomainBase
    {
        private Entity(Data.Entity.Entity entity) {
            
            Id = entity.Id;
            UUID = entity.UUID;
        }

        public static Entity CreateEntity(CooperDbContext _db)
        {
            var changeTrack = _db.Entities.Add(new Data.Entity.Entity()
            {
                UUID = Guid.NewGuid()
            });
            _db.SaveChanges();

            return new Entity(changeTrack.Entity);
        }

        public static Entity DeleteEntity(Entity entity, CooperDbContext _db)
        {
            var dbEntity = _db.Entities.FirstOrDefault(x => x.Id == entity.Id) ?? throw new Exception("Entity not found");
            _db.Entities.Remove(dbEntity);
            _db.SaveChanges();
            return entity;
        }


        public static Entity FindEntityById(Guid id, CooperDbContext _db)
        {
            var entity = _db.Entities.FirstOrDefault(x =>  x.UUID == id)?? throw new Exception("Entity not found");
            return new Entity(entity);
        }

        public static Entity FindEntityById(int id, CooperDbContext _db)
        {
            var entity =  _db.Entities.FirstOrDefault(x => x.Id == id) ?? throw new Exception("Entity not found");
            return new Entity(entity);
        }

        public int Id { get; }
        public Guid UUID { get; }
    }
}
