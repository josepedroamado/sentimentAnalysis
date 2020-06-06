using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IPublicationSaver
    {
        void AddPublication(Publication aPublication);

        void DeletePublication(Publication aPublication);

        void ModifyPublication(Publication original, Publication modified);

        Publication FetchPublication(Publication aPublication);

        List<Publication> FetchAll();
    }
}
