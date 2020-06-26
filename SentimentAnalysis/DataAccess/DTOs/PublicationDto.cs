using System;

namespace DataAccess
{
    public class PublicationDto
    {
        public Guid PublicationDtoId { get; set; }

        public string Phrase { get; set; }

        public DateTime Date { get; set; }

        public AuthorDto Author { get; set; }
    }
}
