using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IPublicationSaver
    {
        void Add(Publication aPublication);

        void Delete(Publication aPublication);

        void Modify(Publication original, Publication modified);

        Publication Fetch(Publication aPublication);

        List<Publication> FetchAll();

        List<Publication> FetchAllPublicationsOfAuthor(Guid authorId);

        void Clear();
    }
}
