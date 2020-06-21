using System;

namespace BusinessLogic
{
    public class SentimentAdder
    {
        private SystemData data;

        public SentimentAdder(SystemData data)
        {
            this.data = data;
        }

        public void Add(String name, Boolean positive)
        {
            Sentiment newSentiment;
            if (positive)
            {
                newSentiment = new PositiveSentiment(name);
            }
            else
            {
                newSentiment = new NegativeSentiment(name);
            }
            data.sentimentSaver.Add(newSentiment);
        }
    }
}
