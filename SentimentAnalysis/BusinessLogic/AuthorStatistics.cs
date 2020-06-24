using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AuthorStatistics
    {
        private SystemData data;

        public AuthorStatistics(SystemData data)
        {
            this.data = data;
        }

        public int SentimentPublictionsPercentage(Guid author, string sentimentType)
        {
            List<Relation> relations = data.relationSaver.FetchAllWithAuthor(author);
            int totalRelations = relations.Count();
            if (totalRelations < 1)
            {
                return 0;
            }
            int positivePublications = 0;
            foreach (Relation relation in relations)
            {
                if (relation.Sentiment.GetType().Name == sentimentType)
                {
                    positivePublications++;
                }
            }
            decimal total = (positivePublications *100 )/ totalRelations;
            return (int)total;
        }

        public int EntitiesMentioned(Guid author)
        {
            List<Relation> relations = data.relationSaver.FetchAllWithAuthor(author);
            List<Entity> entitiesMentioned = new List<Entity>();
            foreach (Relation relation in relations)
            {
                if (!entitiesMentioned.Contains(relation.Entity) && relation.Entity.Name != "Desconocida")
                {
                    entitiesMentioned.Add(relation.Entity);
                }
            }
            return entitiesMentioned.Count();
        }

        public int DailyPublicationAverage(Guid author)
        {
            List<Relation> relations = data.relationSaver.FetchAllWithAuthor(author);
            int totalRelations = relations.Count();
            DateTime oldest = DateTime.Now;
            foreach (Relation relation in relations)
            {
                if (relation.Publication.Date < oldest)
                {
                    oldest = relation.Publication.Date;
                }
            }
            TimeSpan days = DateTime.Now - oldest;
            double totalDays = days.TotalDays;
            if (totalDays < 1)
            {
                totalDays = 1;
            }
            return totalRelations / (int)totalDays;
        }
    }
}
