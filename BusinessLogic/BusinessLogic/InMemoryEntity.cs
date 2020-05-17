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
        public void AddEntity(Entity aEntity)
        {
            if(this.EntityExists(aEntity.Name))
            {
                throw new ObjectAlreadyExistsException("Entidad");
            }
            this.Entities.Add(aEntity);
        }

        public void DeleteEntity(string aName)
        {
            if (!this.EntityExists(aName))
            {
                throw new ObjectDoesntExistException("Entidad");
            }
            for (int i = 0; i < this.Entities.Count(); i++)
            {
                if (Entities[i].Name == aName)
                {
                    Entities.RemoveAt(i);
                }
            }
            
        }

        public Entity FetchEntity(string aName)
        {
            if (!this.EntityExists(aName))
            {
                throw new ObjectDoesntExistException("Entidad");
            }
            else
            {
                for (int i = 0; i < this.Entities.Count(); i++)
                {
                    if (Entities[i].Name == aName)
                    {
                        return Entities[i];
                    }
                }
            }
            return null;//why?
        }

        public void ModifyEntity(Entity aEntity)
        {
            if (!this.EntityExists(aEntity.Name))
            {
                throw new ObjectDoesntExistException("Entidad");
            }
            else
            {
                for (int i = 0; i < this.Entities.Count(); i++)
                {
                    if (Entities[i].Name == aEntity.Name)
                    {
                        Entities[i] = aEntity;
                    }
                }
            }
        }
        public Boolean EntityExists(string aName)
        {
            for(int i = 0; i < this.Entities.Count(); i++)
            {
                if(Entities[i].Name == aName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
