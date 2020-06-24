using System.Collections.Generic;

namespace BusinessLogic
{
    public class SentimentDeleter
    {
        private SystemData data;

        public SentimentDeleter(SystemData data)
        {
            this.data = data;
        }

        public void Delete(Sentiment sentimentToDelete)
        {
            if (sentimentToDelete != null)
            {
                List<Relation> relations = data.relationSaver.FetchAllWithSentiment(sentimentToDelete.SentimentId);
                foreach (Relation relation in relations)
                {
                    data.relationSaver.Delete(relation);
                }
                data.sentimentSaver.Delete(sentimentToDelete);
            }
        }
    }
}
