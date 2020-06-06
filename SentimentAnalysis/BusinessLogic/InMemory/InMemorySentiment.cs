using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InMemorySentiment : ISentimentSaver
    {
        private List<Sentiment> Sentiments;

        public InMemorySentiment()
        {
            this.Sentiments = new List<Sentiment>();
        }

        public void AddSentiment(Sentiment aSentiment)
        {
            if (!SentimentExists(aSentiment)) Sentiments.Add(aSentiment);
            else throw new ObjectAlreadyExistsException("Sentimiento");
        }

        public void DeleteSentiment(Sentiment aSentiment)
        {
            if (SentimentExists(aSentiment)) Sentiments.Remove(aSentiment);
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public void ModifySentiment(Sentiment original, Sentiment modified)
        {
            if (SentimentExists(original))
            {
                Sentiments[GetSentimentListIndex(original)].SetText(modified.Text);
            }
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public Sentiment FetchSentiment(Sentiment aSentiment)
        {
            if (SentimentExists(aSentiment)) return Sentiments[GetSentimentListIndex(aSentiment)];
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public Sentiment FetchSentiment(int sentimentId)
        {

            if (SentimentExists(sentimentId)) return Sentiments.Find(aSentiment => aSentiment.SentimentId == sentimentId);
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public List<Sentiment> FetchAll()
        {
            return this.Sentiments;
        }

        public List<Sentiment> FetchAllPositiveSentiments()
        {
            return Sentiments.FindAll(sentiment => sentiment.GetType().Name == "PositiveSentiment");
        }

        public List<Sentiment> FetchAllNegativeSentiments()
        {
            return Sentiments.FindAll(sentiment => sentiment.GetType().Name == "NegativeSentiment");
        }

        private int GetSentimentListIndex(Sentiment aSentiment)
        {
            return Sentiments.IndexOf(aSentiment);
        }

        private bool SentimentExists(Sentiment aSentiment)
        {
            if (Sentiments.Contains(aSentiment)) return true;
            else return SentimentExists(aSentiment.Text);
        }

        private bool SentimentExists(int sentimentId)
        {
            return Sentiments.Exists(aSentiment => aSentiment.SentimentId == sentimentId);
        }

        private bool SentimentExists(String sentimentText)
        {
            return Sentiments.Exists(aSentiment => aSentiment.Text.ToLower() == sentimentText.ToLower());
        }
    }
}
