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
            string phrase = publication.Phrase;
            foreach (Entity entity in entities)
            {
                if (phrase.ToLower().Contains(entity.Name.ToLower())) return entity;
            }
            return entitySaver.Fetch(Guid.Parse("c77213bd-ab43-416b-a37a-9a08b81ec6af"));
        }

        public Sentiment AnalyzeSentiment(Publication publication)
        {
            List<Sentiment> sentiments = sentimentSaver.FetchAll();
            string phrase = publication.Phrase.ToLower();
            foreach (Sentiment sentiment in sentiments)
            {
                if (phrase.Contains(sentiment.Text.ToLower())) return sentiment;
            }           
            return sentimentSaver.Fetch(Guid.Parse("6e3512e5-45ff-45ba-b54c-542c81564a20"));
        }

        public Relation AnalyzePublication(Publication publication)
        {
            Entity detectedEntity = AnalyzeEntity(publication);
            Sentiment detectedSentiment = AnalyzeSentiment(publication);
            return new Relation(publication, detectedSentiment, detectedEntity);       
        }
    }
}
