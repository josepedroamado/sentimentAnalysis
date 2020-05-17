using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SystemData
    {
        public IEntitySaver EntitySaver;

        public ISentimentSaver SentimentSaver;

        public IPublicationSaver publicationSaver;

        public SystemData(IEntitySaver entitySaver, ISentimentSaver sentimentSaver, IPublicationSaver publicationSaver)
        {
            this.EntitySaver = entitySaver;
            this.SentimentSaver = sentimentSaver;
            this.publicationSaver = publicationSaver;
        }
    }
}
