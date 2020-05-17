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
        public void AddPublication(Publication aPublication)
        {
            if (this.PublicationExists(aPublication.Id))
            {
                throw new ObjectAlreadyExistsException("Publicacion");
            }
            this.Publications.Add(aPublication);
        }

        public void DeletePublication(int aId)
        {
            if (!this.PublicationExists(aId))
            {
                throw new ObjectDoesntExistException("Publicacion");
            }
            for (int i = 0; i < this.Publications.Count(); i++)
            {
                if (Publications[i].Id == aId)
                {
                    Publications.RemoveAt(i);
                }
            }

        }

        public Publication FetchPublication(int aId)
        {
            if (!this.PublicationExists(aId))
            {
                throw new ObjectDoesntExistException("Publicacion");
            }
            else
            {
                for (int i = 0; i < this.Publications.Count(); i++)
                {
                    if (Publications[i].Id == aId)
                    {
                        return Publications[i];
                    }
                }
            }
            return null;//why?
        }

        public void ModifyPublication(Publication aPublication)
        {
            if (!this.PublicationExists(aPublication.Id))
            {
                throw new ObjectDoesntExistException("Publicacion");
            }
            else
            {
                for (int i = 0; i < this.Publications.Count(); i++)
                {
                    if (Publications[i].Id == aPublication.Id)
                    {
                        Publications[i] = aPublication;
                    }
                }
            }
        }
        public Boolean PublicationExists(int aId)
        {
            for (int i = 0; i < this.Publications.Count(); i++)
            {
                if (Publications[i].Id == aId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}