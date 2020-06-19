using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Sentiment
    {
        public Guid SentimentId { get; set; }

        public String Text { get; set; }

        private const int MAX_BODY_TEXT = 100;

        private const int MIN_BODY_TEXT = 1;

        public override bool Equals(Object obj)
        {
            Sentiment sentiment = obj as Sentiment;
            if (sentiment != null) return this.SentimentId == sentiment.SentimentId;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.SentimentId.GetHashCode();
        }

        public void SetText(String aText)
        {
            IsTextCorrect(aText);
            this.Text = aText;
        }

        public void IsTextCorrect(String aText)
        {
            IsTextTooLong(aText);
            IsTextTooShort(aText);
        }

        private void IsTextTooLong(String aText)
        {
            if (aText.Length > MAX_BODY_TEXT)
            {
                throw new TextTooLongException(MAX_BODY_TEXT);
            }
        }

        private void IsTextTooShort(String aText)
        {
            if (aText.Length <= MIN_BODY_TEXT)
            {
                throw new TextTooShortException(MIN_BODY_TEXT);
            }
        }
    }
}
