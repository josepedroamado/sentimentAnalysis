using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InMemoryRelation : IRelationSaver
    {
        private List<Relation> Relations;

        public InMemoryRelation()
        {
            this.Relations = new List<Relation>();
        }

        public void AddRelation(Relation aRelation)
        {
            if (!RelationExists(aRelation)) Relations.Add(aRelation);
            else throw new ObjectAlreadyExistsException("Relacion");
        }

        public void DeleteRelation(Relation aRelation)
        {
            if (RelationExists(aRelation)) Relations.Remove(aRelation);
            else throw new ObjectDoesntExistException("Relacion");
        }

        public void ModifyRelation(Relation original, Relation modified)
        {
            if (RelationExists(original))
            {
                Relations[GetRelationListIndex(original)].Entity = modified.Entity;
                Relations[GetRelationListIndex(original)].Publication = modified.Publication;
                Relations[GetRelationListIndex(original)].Sentiment = modified.Sentiment;
            }
            else throw new ObjectDoesntExistException("Relacion");
        }

        public Relation FetchRelation(Relation aRelation)
        {
            if (RelationExists(aRelation)) return Relations[GetRelationListIndex(aRelation)];
            else throw new ObjectDoesntExistException("Relacion");
        }

        private int GetRelationListIndex(Relation aRelation)
        {
            return Relations.IndexOf(aRelation);
        }

        private bool RelationExists(Relation aRelation)
        {
            return Relations.Contains(aRelation);
        }

    }
}
