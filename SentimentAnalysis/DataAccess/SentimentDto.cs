using System;

namespace DataAccess
{
    public abstract class SentimentDto
    {
        public int SentimentDtoId { get; set; }

        public String Text { get; set; }
    }
}