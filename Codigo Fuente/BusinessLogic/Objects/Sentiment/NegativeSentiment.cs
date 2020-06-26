using System;

namespace BusinessLogic
{
    public class NegativeSentiment : Sentiment
    {
        public NegativeSentiment(String Text)
        {
            SentimentId = Guid.NewGuid();
            SetText(Text);
        }
    }
}
