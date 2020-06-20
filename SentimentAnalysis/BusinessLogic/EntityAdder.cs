using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EntityAdder
    {
        public EntityAdder(SystemData Data, String Name)
        {
            Entity entityToAdd = CreateEntity(Name);
            AddEntity(entityToAdd, Data);
        }
        private Entity CreateEntity(String Name)
        {
            Entity entity = new Entity(Name);
            return entity;
        }
        private void AddEntity(Entity entityToAdd, SystemData Data)
        {
            Data.entitySaver.Add(entityToAdd);
        }
    }
}
