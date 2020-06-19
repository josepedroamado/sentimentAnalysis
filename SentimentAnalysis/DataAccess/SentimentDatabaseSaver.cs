using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class SentimentDatabaseSaver : ISentimentSaver
    {
        public void AddSentiment(Sentiment aSentiment)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                if (context.Sentiments.Any(sentiment => sentiment.Text == aSentiment.Text))
                {
                    throw new ObjectAlreadyExistsException("Sentimiento");
                }
                else
                {
                    SentimentDto newSentiment = convert.ConvertToDto(aSentiment);
                    context.Sentiments.Add(newSentiment);
                    context.SaveChanges();
                    aSentiment.SentimentId = aSentiment.SentimentId;
                }
            }
        }

        public void DeleteSentiment(Sentiment aSentiment)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                SentimentDto sentimentToDelete = context.Sentiments.FirstOrDefault(sentiment => sentiment.Text == aSentiment.Text);
                if (sentimentToDelete == null)
                {
                    throw new ObjectDoesntExistException("Sentimiento");
                }
                else
                {
                    context.Sentiments.Remove(sentimentToDelete);
                    context.SaveChanges();
                }
            }
        }

        public List<Sentiment> FetchAll()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                List<Sentiment> allSentiments = new List<Sentiment>();
                foreach (SentimentDto sentiment in context.Sentiments)
                {
                    allSentiments.Add(convert.ConvertToObject(sentiment));
                }
                return allSentiments;
            }
        }

        public List<Sentiment> FetchAllNegativeSentiments()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                List<Sentiment> allNegativeSentiments = new List<Sentiment>();
                foreach (SentimentDto sentiment in context.Sentiments)
                {
                    if (sentiment.GetType().Name.Equals("NegativeSentimentDto"))
                    {
                        allNegativeSentiments.Add(convert.ConvertToObject(sentiment));
                    }
                }
                return allNegativeSentiments;
            }
        }

        public List<Sentiment> FetchAllPositiveSentiments()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                List<Sentiment> allPositiveSentiments = new List<Sentiment>();
                foreach (SentimentDto sentiment in context.Sentiments)
                {
                    if (sentiment.GetType().Name.Equals("PositiveSentimentDto"))
                    {
                        allPositiveSentiments.Add(convert.ConvertToObject(sentiment));
                    }
                }
                return allPositiveSentiments;
            }
        }

        public Sentiment FetchSentiment(Sentiment aSentiment)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                SentimentDto fetchedSentiment = context.Sentiments.FirstOrDefault(sentiment => sentiment.Text == aSentiment.Text);
                if (fetchedSentiment == null)
                {
                    throw new ObjectDoesntExistException("Sentimiento");
                }
                else
                {
                    return convert.ConvertToObject(fetchedSentiment);
                }
            }
        }

        public Sentiment FetchSentiment(int sentimentId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                SentimentDto fetchedSentiment = context.Sentiments.FirstOrDefault(sentiment => sentiment.SentimentDtoId == sentimentId);
                if (fetchedSentiment == null)
                {
                    throw new ObjectDoesntExistException("Sentimiento");
                }
                else
                {
                    return convert.ConvertToObject(fetchedSentiment);
                }
            }
        }

        public void ModifySentiment(Sentiment original, Sentiment modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                SentimentDto fetchedSentiment = context.Sentiments.FirstOrDefault(sentiment => sentiment.Text == original.Text);
                if (fetchedSentiment == null)
                {
                    throw new ObjectDoesntExistException("Sentimiento");
                }
                else
                {
                    fetchedSentiment.Text = modified.Text;
                    context.SaveChanges();
                }
            }
        }

        public void Clear()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                context.Sentiments.RemoveRange(context.Sentiments);
                context.SaveChanges();
            }
        }
    }
}
