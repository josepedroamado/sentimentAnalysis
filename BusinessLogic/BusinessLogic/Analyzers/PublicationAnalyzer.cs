using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PublicationAnalyzer
    {
        private ISentimentSaver sentimentSaver;
        private IEntitySaver entitySaver;

        public PublicationAnalyzer(ISentimentSaver sentimentSaver, IEntitySaver entitySaver)
        {
            this.sentimentSaver = sentimentSaver;
            this.entitySaver = entitySaver;
        }

        public Entity AnalyzeEntity(Publication publication)
        {
            List<Entity> entities = entitySaver.FetchAll();
            String phrase = publication.Phrase;
            foreach (Entity entity in entities)
            {
                if (phrase.Contains(entity.Name)) return entity;
            }
            return null;
        }

        public Sentiment AnalyzeSentiment(Publication publication)
        {
            List<Sentiment> sentiments = sentimentSaver.FetchAll();
            String phrase = publication.Phrase;
            foreach (Sentiment sentiment in sentiments)
            {
                if (phrase.Contains(sentiment.Text)) return sentiment;
            }           
            return null;
        }

        public Relation AnalyzePublication(Publication publication)
        {
            Entity detectedEntity = AnalyzeEntity(publication);
            if (detectedEntity == null) return new Relation(publication, null, null);
            else
            {
                Sentiment detectedSentiment = AnalyzeSentiment(publication);
                return new Relation(publication, detectedSentiment, detectedEntity);
            }
        }
    }
}
