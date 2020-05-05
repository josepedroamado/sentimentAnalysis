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

        private const int MAX_BODY_TEXT = 100;
        private const int MIN_BODY_TEXT = 1;

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

            IsTextCorrect(aText);
            this.Text = aText;
        }
        public void IsTextCorrect(String AText)
        {
            IsTextTooLong(AText);
            IsTextTooShortOrEmpty(AText);
        }
        private void IsTextTooLong(String aText)
        {
            if (aText.Length > MAX_BODY_TEXT)
            {
                throw new TextTooLongException(MAX_BODY_TEXT);
            }
        }
        private void IsTextTooShortOrEmpty(String aText)
        {
            if (aText.Length <= MIN_BODY_TEXT)
            {
                throw new TextTooShortException(MIN_BODY_TEXT);
            }
            if (aText[0] == ' ')
            {
                throw new TextTooShortException(MIN_BODY_TEXT);
            }
        }
    }
}
