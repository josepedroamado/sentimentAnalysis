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

        public Author Author { get; set; }

        private const int MAX_BODY_TEXT = 100;

        private const int MIN_BODY_TEXT = 2;

        public Publication(string aPhrase, DateTime aDate, Author anAuthor)
        {
            AssignId();
            SetPhrase(aPhrase);
            this.Date = aDate;
            this.Author = anAuthor;
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
        private void SetPhrase(String aPhrase)
        {
            IsPhraseTooShortOrEmpty(aPhrase);
            IsPhraseTooLong(aPhrase);
            this.Phrase = aPhrase;

        }
        private void IsPhraseTooShortOrEmpty(String aPhrase)
        {
            if (aPhrase.Length <= MIN_BODY_TEXT)
            {
                throw new TextTooShortException(MIN_BODY_TEXT);
            }
        }
        private void IsPhraseTooLong(String aPhrase)
        {
            if (aPhrase.Length > MAX_BODY_TEXT)
            {
                throw new TextTooLongException(MAX_BODY_TEXT);
            }
        }
    }
}
