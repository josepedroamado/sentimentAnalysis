using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class SentimentDeleter
    {
        public SentimentDeleter(SystemData data, Sentiment sentimentToDelete)
        {
            DeleteEntity(sentimentToDelete, data);
        }
        private void DeleteEntity(Sentiment sentimentToDelete, SystemData data)
        {
            data.sentimentSaver.Delete(sentimentToDelete);
        }
    }
}
