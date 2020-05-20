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
            Publication PublicationToAdd = CreatePublication(Phrase, Date);
            AddPublicationToAdd(PublicationToAdd, Data);
        }
        private Publication CreatePublication(String Phrase, DateTime Date)
        {
            Publication publication = new Publication(Phrase, Date);
            return publication;
        }
        private void AddPublicationToAdd(Publication PublicationToAdd, SystemData Data)
        {
            Data.publicationSaver.AddPublication(PublicationToAdd);
        }
    }
}
