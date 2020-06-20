using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PublicationAdder
    {
        public PublicationAdder(SystemData Data, String Phrase, DateTime Date)
        {
            Publication publicationToAdd = new Publication(Phrase, Date);
            AddPublicationToAdd(publicationToAdd, Data);
        }

        private void AddPublicationToAdd(Publication publicationToAdd, SystemData data)
        {
            data.publicationSaver.Add(publicationToAdd);

            RelationAdder relationAdder = new RelationAdder(data);
            relationAdder.AddRelation(publicationToAdd);

            AlarmAnalyzer alarmAnalyzer = new AlarmAnalyzer(data);
            alarmAnalyzer.AnalyzeAllAlarms();
        }
    }
}
