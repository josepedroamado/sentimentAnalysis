using System;

namespace BusinessLogic
{
    public class SystemData
    {
        public IEntitySaver entitySaver;

        public ISentimentSaver sentimentSaver;

        public IPublicationSaver publicationSaver;

        public IRelationSaver relationSaver;

        public IAlarmSaver alarmSaver;

        public IAuthorSaver authorSaver;

        public SystemData(IEntitySaver entitySaver, ISentimentSaver sentimentSaver, IPublicationSaver publicationSaver, IRelationSaver relationSaver, IAlarmSaver alarmSaver, IAuthorSaver authorSaver)
        {
            this.entitySaver = entitySaver;
            this.sentimentSaver = sentimentSaver;
            this.publicationSaver = publicationSaver;
            this.relationSaver = relationSaver;
            this.alarmSaver = alarmSaver;
            this.authorSaver = authorSaver;

            Entity unknownEntity;
            try
            {
                unknownEntity = entitySaver.Fetch(Guid.Parse("c77213bd-ab43-416b-a37a-9a08b81ec6af"));
            }
            catch (ObjectDoesntExistException)
            {
                unknownEntity = new Entity("Desconocida")
                {
                    EntityId = Guid.Parse("c77213bd-ab43-416b-a37a-9a08b81ec6af")
                };
                entitySaver.Add(unknownEntity);
            }

            Sentiment unknownSentiment;
            try
            {
                unknownSentiment = sentimentSaver.Fetch(Guid.Parse("6e3512e5-45ff-45ba-b54c-542c81564a20"));
            }
            catch (ObjectDoesntExistException)
            {
                unknownSentiment = new NeutralSentiment("Desconocido")
                {
                    SentimentId = Guid.Parse("6e3512e5-45ff-45ba-b54c-542c81564a20")
                };
                sentimentSaver.Add(unknownSentiment);
            }
        }
    }
}
