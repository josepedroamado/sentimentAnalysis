using System;

namespace BusinessLogic
{
    public class NeutralSentiment: Sentiment
    {
        public NeutralSentiment(String Text)
        {
            SentimentId = Guid.NewGuid();
            SetText(Text);
        }
    }
}
