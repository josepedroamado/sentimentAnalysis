using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IEntitySaver
    {
        void Add(Entity anEntity);

        void Delete(Entity anEntity);

        void Modify(Entity original, Entity modified);

        Entity Fetch(Entity anEntity);

        Entity Fetch(Guid entityId);

        List<Entity> FetchAll();

        void Clear();
    }
}
