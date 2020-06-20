namespace BusinessLogic
{
    public class RelationAdder
    {
        private SystemData data;
        private PublicationAnalyzer publicationAnalyzer;

        public RelationAdder(SystemData data)
        {
            this.data = data;
            this.publicationAnalyzer = new PublicationAnalyzer(data.sentimentSaver, data.entitySaver);
        }
        
        public void Add(Publication publication)
        {
            Relation relation = publicationAnalyzer.AnalyzePublication(publication);
            data.relationSaver.Add(relation);
        }
    }
}
