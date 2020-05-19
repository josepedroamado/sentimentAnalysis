using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Publication
    {
        public static int NextId = 1;

        public int PublicationId { get; set; }

        public string Phrase { get; set; }

        public DateTime Date { get; set; }

        public Publication(string aPhrase, DateTime aDate)
        {
            AssignId();
            this.Phrase = aPhrase;
            this.Date = aDate;
        }

        public override bool Equals(object obj)
        {
            Publication publication = obj as Publication;
            if (publication != null) return this.PublicationId == publication.PublicationId;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.PublicationId.GetHashCode();
        }

        public int GetNextId()
        {
            return NextId;
        }

        private void AssignId()
        {
            this.PublicationId = NextId;
            NextId++;
        }
    }
}
