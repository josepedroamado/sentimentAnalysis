using BusinessLogic;
using System;

namespace DataAccess
{
    public class RelationDto
    {
        public Guid RelationDtoId { get; set; }

        public PublicationDto Publication { get; set; }

        public SentimentDto Sentiment { get; set; }

        public EntityDto Entity { get; set; }
    }
}
