using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

