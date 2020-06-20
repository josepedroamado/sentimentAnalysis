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
        }
    }
}
