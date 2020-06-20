using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InMemoryEntity : IEntitySaver
    {
        private List<Entity> Entities;

        public InMemoryEntity()
        {
            this.Entities = new List<Entity>();
        }

        public void Add(Entity anEntity)
        {
            if (!EntityExists(anEntity)) Entities.Add(anEntity);
            else throw new ObjectAlreadyExistsException("Entidad");
        }

        public void Delete(Entity anEntity)
        {
            if (EntityExists(anEntity)) Entities.Remove(anEntity);
            else throw new ObjectDoesntExistException("Entidad");
        }

        public void Modify(Entity original, Entity modified)
        {
            if (EntityExists(original))
            {
                Entities[GetEntityListIndex(original)].Name = modified.Name;
            }
            else throw new ObjectDoesntExistException("Entidad");
        }

        public Entity Fetch(Entity anEntity)
        {
            if (EntityExists(anEntity)) return Entities[GetEntityListIndex(anEntity)];
            else throw new ObjectDoesntExistException("Entidad");
        }

        public Entity Fetch(Guid entityId)
        {            
            if (EntityExists(entityId)) return Entities.Find(anEntity => anEntity.EntityId.Equals(entityId));
            else throw new ObjectDoesntExistException("Entidad");
        }

        private int GetEntityListIndex(Entity anEntity)
        {
            return Entities.IndexOf(anEntity);
        }

        private bool EntityExists(Entity anEntity)
        {
            if (Entities.Contains(anEntity)) return true;
            else return EntityExists(anEntity.Name);
        }

        private bool EntityExists(Guid entityId)
        {
            return Entities.Exists(anEntity => anEntity.EntityId == entityId);
        }

        private bool EntityExists(String entityName)
        {
            return Entities.Exists(anEntity => anEntity.Name.ToLower() == entityName.ToLower());
        }

        public List<Entity> FetchAll()
        {
            return this.Entities;
        }

        public void Clear()
        {
            Entities.Clear();
        }
    }
}
