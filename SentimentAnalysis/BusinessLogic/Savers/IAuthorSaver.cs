using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IAuthorSaver
    {
        void Add(Author anAuthor);

        void Delete(Author anAuthor);

        void Modify(Author original, Author modified);

        Author Fetch(Guid anAuthor);

        List<Author> FetchAll();

        void Clear();
    }
}
