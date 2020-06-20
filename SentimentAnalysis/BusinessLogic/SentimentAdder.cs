using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SentimentAdder
    {
        public SentimentAdder(SystemData Data, String Name, Boolean positive)
        {
            Sentiment SentimentToAdd = CreateSentiment(Name , positive);
            AddSentiment(SentimentToAdd, Data);
        }
        private Sentiment CreateSentiment(String Name , Boolean Positive)
        {
            Sentiment sentiment;
            if (Positive)
            {
                sentiment = new PositiveSentiment(Name);
            }
            else
            {
                sentiment = new NegativeSentiment(Name);
            }

            return sentiment;
        }
        private void AddSentiment(Sentiment SentimentToAdd, SystemData Data)
        {
            Data.sentimentSaver.Add(SentimentToAdd);
        }
    }
}
