using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Entity
    {
        public string Name { get; set; }
        //private List<Sentiment> Sentiments;
        public Entity(String aName)
        {
            this.Name = aName;
            //this.Sentiments = new List<Sentiment>();
        }
        //public List<Sentiment> GetSentiments()
        //{
        //    return this.Sentiments;
        //}

        //public void AddSentiment(Sentiment aSentiment)
        //{
        //    this.Sentiments.Add(aSentiment);
        //}
    }
}
