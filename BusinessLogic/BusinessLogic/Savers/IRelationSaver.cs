using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IRelationSaver
    {
        void AddRelation(Relation aRelation);

        void DeleteRelation(Relation aRelation);

        void ModifyRelation(Relation original, Relation modified);

        Relation FetchRelation(Relation aRelation);

        List<Relation> FetchAll();
    }
}
