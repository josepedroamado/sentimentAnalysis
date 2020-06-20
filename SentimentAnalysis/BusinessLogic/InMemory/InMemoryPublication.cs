using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InMemoryPublication : IPublicationSaver
    {
        private List<Publication> Publications;

        public InMemoryPublication()
        {
            this.Publications = new List<Publication>();
        }

        public void Add(Publication aPublication)
        {
            if (!PublicationExists(aPublication)) Publications.Add(aPublication);
            else throw new ObjectAlreadyExistsException("Publicacion");
        }

        public void Delete(Publication aPublication)
        {
            if (PublicationExists(aPublication)) Publications.Remove(aPublication);
            else throw new ObjectDoesntExistException("Publicacion");
        }

        public void Modify(Publication original, Publication modified)
        {
            if (PublicationExists(original))
            {
                Publications[GetPublicationListIndex(original)].Date = modified.Date;
                Publications[GetPublicationListIndex(original)].Phrase = modified.Phrase;
            }
            else throw new ObjectDoesntExistException("Publicacion");
        }

        public Publication Fetch(Publication aPublication)
        {
            if (PublicationExists(aPublication)) return Publications[GetPublicationListIndex(aPublication)];
            else throw new ObjectDoesntExistException("Publicacion");
        }

        private int GetPublicationListIndex(Publication aPublication)
        {
            return Publications.IndexOf(aPublication);
        }

        private bool PublicationExists(Publication aPublication)
        {
            return Publications.Contains(aPublication);
        }

        public List<Publication> FetchAll()
        {
            return this.Publications;
        }

        public void Clear()
        {
            Publications.Clear();
        }
    }
}