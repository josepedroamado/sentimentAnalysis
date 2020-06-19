using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PositiveSentiment : Sentiment
    {
        public PositiveSentiment(String Text)
        {
            SentimentId = Guid.NewGuid();
            SetText(Text);
        }
    }
}
