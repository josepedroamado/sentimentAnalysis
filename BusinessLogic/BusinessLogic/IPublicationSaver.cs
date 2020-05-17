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

        void DeletePublication(int id);

        void ModifyPublication(Publication aPublication);

        Publication FetchPublication(int id);
    }
}
