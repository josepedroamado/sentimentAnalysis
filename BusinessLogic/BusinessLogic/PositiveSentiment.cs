using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PositiveSentiment : Sentiment
    {
        public PositiveSentiment(String Title, String Text)
        {
            this.Title = Title;
            this.Text = Text;
        }
    }
}
