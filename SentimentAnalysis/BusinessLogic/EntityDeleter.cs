using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class EntityDeleter
    {
        public EntityDeleter(SystemData Data, Entity entityToDelete)
        {
            
            DeleteEntity(entityToDelete, Data);
        }

        private void DeleteEntity(Entity entityToDelete, SystemData data)
        {
            data.entitySaver.Delete(entityToDelete);
        }
    }
}
