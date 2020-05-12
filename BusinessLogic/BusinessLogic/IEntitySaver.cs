using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IEntitySaver
    {


        void AddEntity(Entity aEntity);

        void DeleteEntity(String name);

        void ModifyEntity(Entity aEntity);

        Entity FetchEntity(String name);
    }
}
