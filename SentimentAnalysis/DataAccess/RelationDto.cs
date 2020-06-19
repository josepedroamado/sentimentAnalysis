using BusinessLogic;

namespace DataAccess
{
    public class RelationDto
    {
        public int RelationDtoId { get; set; }

        public PublicationDto Publication { get; set; }

        public SentimentDto Sentiment { get; set; }

        public EntityDto Entity { get; set; }
    }
}
