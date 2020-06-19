using System;

namespace DataAccess
{
    public abstract class SentimentDto
    {
        public Guid SentimentDtoId { get; set; }

        public String Text { get; set; }
    }
}