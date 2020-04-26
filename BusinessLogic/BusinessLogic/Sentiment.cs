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

        public override bool Equals(Object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;
            Sentiment s = (Sentiment)obj;
            return (Title == s.Title);
        }
        public override int GetHashCode()
        {
            return Tuple.Create(Title, Text).GetHashCode();
        }
    }
}
