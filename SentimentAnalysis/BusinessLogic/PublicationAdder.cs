using System;

namespace BusinessLogic
{
    public class PublicationAdder
    {
        private SystemData data;

        public PublicationAdder(SystemData data)
        {
            this.data = data;
        }

        public void Add(String phrase, DateTime date, Author author)
        {
            Publication newPublication = new Publication(phrase, date, author);
            data.publicationSaver.Add(newPublication);

            RelationAdder relationAdder = new RelationAdder(data);
            relationAdder.Add(newPublication);

            AlarmAnalyzer alarmAnalyzer = new AlarmAnalyzer(data);
            alarmAnalyzer.AnalyzeAllAlarms();
        }
    }
}
