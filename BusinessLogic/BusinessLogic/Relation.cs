using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Relation
    {
        public Publication Publication { get; set; }
        public Sentiment Sentiment { get; set; }
        public Entity Entity { get; set; }

        public Relation(Publication aPublication, Sentiment aSentiment, Entity anEntity)
        {
            this.Publication = aPublication;
            this.Sentiment = aSentiment;
            this.Entity = anEntity;
        }
    }
}
