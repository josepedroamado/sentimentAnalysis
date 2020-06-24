using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Relation
    {
        public Guid RelationId { get; set; }

        public Publication Publication { get; set; }

        public Sentiment Sentiment { get; set; }

        public Entity Entity { get; set; }
        
        public Relation(Publication aPublication, Sentiment aSentiment, Entity anEntity)
        {
            this.RelationId = Guid.NewGuid();
            this.Publication = aPublication;
            this.Sentiment = aSentiment;
            this.Entity = anEntity;
        }

        public override bool Equals(object obj)
        {
            Relation relation = obj as Relation;
            if (relation != null) return this.RelationId.Equals(relation.RelationId);
            else return false;
        }

        public override int GetHashCode()
        {
            return this.RelationId.GetHashCode();
        }
    }
}
