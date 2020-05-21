using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SystemData
    {
        public IEntitySaver entitySaver;

        public ISentimentSaver sentimentSaver;

        public IPublicationSaver publicationSaver;

        public IRelationSaver relationSaver;

        public IAlarmSaver alarmSaver;

        public SystemData(IEntitySaver entitySaver, ISentimentSaver sentimentSaver, IPublicationSaver publicationSaver, IRelationSaver relationSaver, IAlarmSaver alarmSaver)
        {
            this.entitySaver = entitySaver;
            this.sentimentSaver = sentimentSaver;
            this.publicationSaver = publicationSaver;
            this.relationSaver = relationSaver;
            this.alarmSaver = alarmSaver;
        }
    }
}
