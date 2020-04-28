using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Sentiment
    {
        public string Title { get; set; }
        public string Text { get; set; }

        readonly int MAX_BODY_TEXT = 100;

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Sentiment s = (Sentiment)obj;
            return (Title.ToLower() == s.Title.ToLower());
        }
        public override int GetHashCode()
        {
            return Tuple.Create(Title, Text).GetHashCode();
        }
        public void SetText(String aText)
        {
            if(aText.Length > MAX_BODY_TEXT)
            {
                throw new TextToLongException(MAX_BODY_TEXT);
            }
        }
    }
}
