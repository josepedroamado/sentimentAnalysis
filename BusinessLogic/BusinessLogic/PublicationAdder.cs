using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PublicationAdder
    {
        public PublicationAdder(SystemData Data, String Phrase, DateTime Date, Author anAuthor)
        {
            Publication PublicationToAdd = CreatePublication(Phrase, Date, anAuthor);
            AddPublicationToAdd(PublicationToAdd, Data);
        }
        private Publication CreatePublication(String Phrase, DateTime Date, Author anAuthor)
        {
            Publication publication = new Publication(Phrase, Date, anAuthor);
            return publication;
        }
        private void AddPublicationToAdd(Publication PublicationToAdd, SystemData Data)
        {
            Data.publicationSaver.AddPublication(PublicationToAdd);
            RelationAdder relationAdder = new RelationAdder(Data);
            relationAdder.AddRelation(PublicationToAdd);
            AlarmAnalyzer alarmAnalyzer = new AlarmAnalyzer(Data);
            alarmAnalyzer.AnalyzeAllAlarms();
        }
    }
}
