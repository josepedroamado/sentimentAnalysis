using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEntitySaver
    {
        string ActualId { get; set; }
        List<Entity> Entities { get; set; }

        void AddEntity(Entity aEntity);

        void DeleteEntity(int aId);

        void ModifyEntity(Entity aEntity);
    }
}
