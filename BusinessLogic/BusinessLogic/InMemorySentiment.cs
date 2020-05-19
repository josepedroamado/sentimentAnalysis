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

        private int GetSentimentListIndex(Sentiment aSentiment)
        {
            return Sentiments.IndexOf(aSentiment);
        }

        private bool SentimentExists(Sentiment aSentiment)
        {
            return Sentiments.Contains(aSentiment);
        }
    }
}
