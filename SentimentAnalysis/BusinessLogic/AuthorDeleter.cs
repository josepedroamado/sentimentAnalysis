using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

