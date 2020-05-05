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
        private List<Sentiment> Sentiments;
        public Entity(String aName)
        {
            this.Name = aName;
            this.Sentiments = new List<Sentiment>();
        }
    }
}
