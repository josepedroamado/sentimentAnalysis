using System;

namespace BusinessLogic
{
    public class AuthorAdder
    {
        private SystemData data;

        public AuthorAdder(SystemData data)
        {
            this.data = data;
        }

        public void Add(String firstName, String lastName, String userName, DateTime dateOfBirth)
        {
            Author newAuthor = new Author(userName, firstName, lastName, dateOfBirth);
            data.authorSaver.Add(newAuthor);
        }

        public void Modify(Guid original, string newUsername, string newFirstName, string newLastName, DateTime newBirthdate)
        {
            Author originalAuthor = data.authorSaver.Fetch(original);
            Author modifiedAuthor = new Author(newUsername, newFirstName, newLastName, newBirthdate);
            data.authorSaver.Modify(originalAuthor, modifiedAuthor);
        }
    }
}

