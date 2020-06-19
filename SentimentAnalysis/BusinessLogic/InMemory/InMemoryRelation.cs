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

        public Relation FetchRelation(Guid publicationId)
        {
            if(this.Relations.Exists(relation => relation.Publication.PublicationId.Equals(publicationId)))
            {
                return this.Relations.Find(relation => relation.Publication.PublicationId.Equals(publicationId));
            }
            else throw new ObjectDoesntExistException("Relacion");
        }

        public List<Relation> FetchAll()
        {
            return this.Relations;
        }

        private int GetRelationListIndex(Relation aRelation)
        {
            return Relations.IndexOf(aRelation);
        }

        private bool RelationExists(Relation aRelation)
        {
            return Relations.Contains(aRelation);
        }

        public List<Publication> FetchAllPublicationsOfEntity(Guid entityId)
        {
            List<Relation> entityRelations = this.Relations.FindAll(relation => relation.Entity.EntityId.Equals(entityId));
            List<Publication> entityPublications = new List<Publication>();
            foreach (Relation relation in entityRelations)
            {
                entityPublications.Add(relation.Publication);
            }
            return entityPublications;
        }

        public void Clear()
        {
            Relations.Clear();
        }
    }
}
