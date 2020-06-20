using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface ISentimentSaver
    {
        void Add(Sentiment aSentiment);

        void Delete(Sentiment aSentiment);

        void Modify(Sentiment original, Sentiment modified);

        Sentiment Fetch(Sentiment aSentiment);

        Sentiment Fetch(Guid sentimentId);

        List<Sentiment> FetchAll();

        List<Sentiment> FetchAllPositive();

        List<Sentiment> FetchAllNegative();

        void Clear();
    }
}
