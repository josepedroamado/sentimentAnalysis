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

        public void AddEntity(Entity anEntity)
        {
            if (!EntityExists(anEntity)) Entities.Add(anEntity);
            else throw new ObjectAlreadyExistsException("Entidad");
        }

        public void DeleteEntity(Entity anEntity)
        {
            if (EntityExists(anEntity)) Entities.Remove(anEntity);
            else throw new ObjectDoesntExistException("Entidad");
        }

        public void ModifyEntity(Entity original, Entity modified)
        {
            if (EntityExists(original))
            {
                Entities[GetEntityListIndex(original)].Name = modified.Name;
            }
            else throw new ObjectDoesntExistException("Entidad");
        }

        public Entity FetchEntity(Entity anEntity)
        {
            if (EntityExists(anEntity)) return Entities[GetEntityListIndex(anEntity)];
            else throw new ObjectDoesntExistException("Entidad");
        }

        private int GetEntityListIndex(Entity anEntity)
        {
            return Entities.IndexOf(anEntity);
        }

        private bool EntityExists(Entity anEntity)
        {
            return Entities.Contains(anEntity);
        }

        public List<Entity> FetchAll()
        {
            return this.Entities;
        }
    }
}
