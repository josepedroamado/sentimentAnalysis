using System.Collections.Generic;

namespace BusinessLogic

{
    public class AuthorDeleter
    {
        private SystemData data;

        public AuthorDeleter(SystemData data)
        {
            this.data = data;
        }

        public void Delete(Author authorToDelete)
        {
            if (authorToDelete != null)
            {
                List<Publication> publications = data.publicationSaver.FetchAllPublicationsOfAuthor(authorToDelete.AuthorId);
                foreach (Publication publicationToDelete in publications)
                {
                    Relation relationToDelete = data.relationSaver.FetchWithPublication(publicationToDelete.PublicationId);
                    data.relationSaver.Delete(relationToDelete);
                    data.publicationSaver.Delete(publicationToDelete);
                }
                data.authorSaver.Delete(authorToDelete);
            }
        }
    }
}
