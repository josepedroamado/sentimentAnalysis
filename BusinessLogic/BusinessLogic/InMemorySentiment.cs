using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InMemorySentiment : ISentimentSaver
    {
        public void AddSentiment(Sentiment aSentiment)
        {
            throw new NotImplementedException();
        }

        public void DeleteSentiment(Sentiment aSentiment)
        {
            throw new NotImplementedException();
        }

        public void ModifySentiment(Sentiment original, Sentiment modified)
        {
            throw new NotImplementedException();
        }

        public Sentiment FetchSentiment(Sentiment aSentiment)
        {
            throw new NotImplementedException();
        }
    }
}
