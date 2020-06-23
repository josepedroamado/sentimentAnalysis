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
            data.authorSaver.Delete(authorToDelete);
        }
    }
}
