using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Publication
    {
        public string Phrase { get; set; }

        public DateTime Date { get; set; }
    
        public int Id { get; set; }

        public Publication(string aPhrase, DateTime aDate, int anId)
        {
            this.Phrase = aPhrase;
            this.Date = aDate;
            this.Id = anId;
        }
    }
}
