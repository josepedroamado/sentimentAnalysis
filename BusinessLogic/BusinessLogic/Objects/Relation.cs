using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Relation
    {
        public static int NextId = 1;

        public int RelationId { get; set; }

        public Publication Publication { get; set; }

        public Sentiment Sentiment { get; set; }

        public Entity Entity { get; set; }
        
        public Relation(Publication aPublication, Sentiment aSentiment, Entity anEntity)
        {
            AssignId();
            this.Publication = aPublication;
            this.Sentiment = aSentiment;
            this.Entity = anEntity;
        }

        public override bool Equals(object obj)
        {
            Relation relation = obj as Relation;
            if (relation != null) return this.RelationId == relation.RelationId;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.RelationId.GetHashCode();
        }

        public int GetNextId()
        {
            return NextId;
        }

        private void AssignId()
        {
            this.RelationId = NextId;
            NextId++;
        }
    }
}
