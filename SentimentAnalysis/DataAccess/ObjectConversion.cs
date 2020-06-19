using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ObjectConversion
    {
        public ObjectConversion()
        {

        }

        public EntityDto ConvertToDto(Entity anEntity)
        {
            EntityDto convertedEntity = new EntityDto
            {
                EntityDtoId = anEntity.EntityId,
                Name = anEntity.Name
            };
            return convertedEntity;
        }

        public Entity ConvertToObject(EntityDto anEntityDto)
        {
            Entity convertedEntity = new Entity(anEntityDto.Name)
            {
                EntityId = anEntityDto.EntityDtoId
            };
            return convertedEntity;
        }

        public PublicationDto ConvertToDto(Publication aPublication)
        {
            PublicationDto convertedPublication = new PublicationDto
            {
                PublicationDtoId = aPublication.PublicationId,
                Phrase = aPublication.Phrase,
                Date = aPublication.Date
            };
            return convertedPublication;
        }

        public Publication ConvertToObject(PublicationDto aPublication)
        {
            Publication convertedPublication = new Publication(aPublication.Phrase, aPublication.Date)
            {
                PublicationId = aPublication.PublicationDtoId
            };
            return convertedPublication;
        }

        public SentimentDto ConvertToDto(Sentiment aSentiment)
        {
            SentimentDto convertedSentiment;
            if (aSentiment.GetType().Name.Equals("PositiveSentiment"))
            {
                convertedSentiment = new PositiveSentimentDto();
            }
            else
            {
                convertedSentiment = new NegativeSentimentDto();
            }
            convertedSentiment.SentimentDtoId = aSentiment.SentimentId;
            convertedSentiment.Text = aSentiment.Text;
            return convertedSentiment;
        }

        public Sentiment ConvertToObject(SentimentDto aSentiment)
        {
            Sentiment convertedSentiment;
            if (aSentiment.GetType().Name.Equals("PositiveSentimentDto"))
            {
                convertedSentiment = new PositiveSentiment(aSentiment.Text);
            }
            else
            {
                convertedSentiment = new NegativeSentiment(aSentiment.Text);
            }
            convertedSentiment.SentimentId = aSentiment.SentimentDtoId;
            return convertedSentiment;
        }

        public RelationDto ConvertToDto(Relation aRelation)
        {
            RelationDto convertedRelation = new RelationDto
            {
                RelationDtoId = aRelation.RelationId,
                Entity = ConvertToDto(aRelation.Entity),
                Publication = ConvertToDto(aRelation.Publication),
                Sentiment = ConvertToDto(aRelation.Sentiment)
            };
            return convertedRelation;
        }
        public Relation ConvertToObject(RelationDto aRelation)
        {
            Relation convertedRelation = new Relation(ConvertToObject(aRelation.Publication),
                                                      ConvertToObject(aRelation.Sentiment),
                                                      ConvertToObject(aRelation.Entity))
            {
                RelationId = aRelation.RelationDtoId
            };
            return convertedRelation;
        }
    }
}
