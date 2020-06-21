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
            data.sentimentSaver.Delete(sentimentToDelete);
        }
    }
}
