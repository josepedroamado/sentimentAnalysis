using System;

namespace BusinessLogic
{
    public class PositiveSentiment : Sentiment
    {
        public PositiveSentiment(String Text)
        {
            SentimentId = Guid.NewGuid();
            SetText(Text);
        }
    }
}
