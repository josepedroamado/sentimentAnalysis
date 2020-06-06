using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEntitySaver
    {
        void AddEntity(Entity anEntity);

        void DeleteEntity(Entity anEntity);

        void ModifyEntity(Entity original, Entity modified);

        Entity FetchEntity(Entity anEntity);

        Entity FetchEntity(int entityId);

        List<Entity> FetchAll();
    }
}
