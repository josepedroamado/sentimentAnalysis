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

        public void Add(Sentiment aSentiment)
        {
            if (!SentimentExists(aSentiment)) Sentiments.Add(aSentiment);
            else throw new ObjectAlreadyExistsException("Sentimiento");
        }

        public void Delete(Sentiment aSentiment)
        {
            if (SentimentExists(aSentiment)) Sentiments.Remove(aSentiment);
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public void Modify(Sentiment original, Sentiment modified)
        {
            if (SentimentExists(original))
            {
                Sentiments[GetSentimentListIndex(original)].SetText(modified.Text);
            }
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public Sentiment Fetch(Sentiment aSentiment)
        {
            if (SentimentExists(aSentiment)) return Sentiments[GetSentimentListIndex(aSentiment)];
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public Sentiment Fetch(Guid sentimentId)
        {

            if (SentimentExists(sentimentId)) return Sentiments.Find(aSentiment => aSentiment.SentimentId.Equals(sentimentId));
            else throw new ObjectDoesntExistException("Sentimiento");
        }

        public List<Sentiment> FetchAll()
        {
            return this.Sentiments;
        }

        public List<Sentiment> FetchAllPositive()
        {
            return Sentiments.FindAll(sentiment => sentiment.GetType().Name == "PositiveSentiment");
        }

        public List<Sentiment> FetchAllNegative()
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

        private bool SentimentExists(Guid sentimentId)
        {
            return Sentiments.Exists(aSentiment => aSentiment.SentimentId.Equals(sentimentId));
        }

        private bool SentimentExists(String sentimentText)
        {
            return Sentiments.Exists(aSentiment => aSentiment.Text.ToLower() == sentimentText.ToLower());
        }

        public void Clear()
        {
            Sentiments.Clear();
        }
    }
}
