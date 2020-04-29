using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Sentiment
    {
        public int Id { get; set; }
        public string Text { get; set; }

        readonly int MAX_BODY_TEXT = 100;
        readonly int MIN_BODY_TEXT = 1;

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Sentiment s = (Sentiment)obj;
            return (Id == Id);
        }
        public override int GetHashCode()
        {
            return Tuple.Create(Id, Text).GetHashCode();
        }
        public void SetText(String aText)
        {
            if(aText.Length > MAX_BODY_TEXT)
            {
                throw new TextTooLongException(MAX_BODY_TEXT);
            }
            this.Text = aText;
            if(aText.Length <= MIN_BODY_TEXT)
            {
                throw new TextTooShortException(MIN_BODY_TEXT);
            }
        }
    }
}
