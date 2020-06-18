using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PositiveSentiment : Sentiment
    {
        private void AssignId()
        {
            this.SentimentId = NextId;
            NextId++;
        }
        public PositiveSentiment(String Text)
        {
            AssignId();
            this.SetText(Text);
        }
    }
}
