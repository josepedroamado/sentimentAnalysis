using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface ISentimentSaver
    {
        void AddSentiment(Entity aSentiment);

        void DeleteSentiment(int id);

        void ModifySentiment(Sentiment aSentiment);

        Entity FetchEntity(int id);
    }
}
