﻿using BusinessLogic;
using System;

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

        public AuthorDto ConvertToDto(Author anAuthor)
        {
            AuthorDto convertedAuthor = new AuthorDto
            {
                AuthorDtoId = anAuthor.AuthorId,
                UserName = anAuthor.UserName,
                FirstName = anAuthor.FirstName,
                LastName = anAuthor.LastName,
                BirthDate = anAuthor.BirthDate
            };
            return convertedAuthor;
        }

        public Author ConvertToObject(AuthorDto anAuthor)
        {
            Author convertedAuthor = new Author(anAuthor.UserName, anAuthor.FirstName, anAuthor.LastName, anAuthor.BirthDate)
            {
                AuthorId = anAuthor.AuthorDtoId
            };
            return convertedAuthor;
        }

        public PublicationDto ConvertToDto(Publication aPublication)
        {
            PublicationDto convertedPublication = new PublicationDto
            {
                PublicationDtoId = aPublication.PublicationId,
                Phrase = aPublication.Phrase,
                Date = aPublication.Date,
                Author = ConvertToDto(aPublication.Author)
            };
            return convertedPublication;
        }

        public Publication ConvertToObject(PublicationDto aPublication)
        {
            Publication convertedPublication = new Publication(aPublication.Phrase, aPublication.Date, ConvertToObject(aPublication.Author))
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
            else if (aSentiment.GetType().Name.Equals("NegativeSentiment"))
            {
                convertedSentiment = new NegativeSentimentDto();
            }
            else
            {
                convertedSentiment = new NeutralSentimentDto();
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
            else if (aSentiment.GetType().Name.Equals("NegativeSentimentDto"))
            {
                convertedSentiment = new NegativeSentiment(aSentiment.Text);
            }
            else
            {
                convertedSentiment = new NeutralSentiment(aSentiment.Text);
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

        public AlarmDto ConvertToDto(Alarm anAlarm)
        {
            AlarmDto convertedAlarm;
            if (anAlarm.GetType().Name.Equals("PositiveAlarm"))
            {
                convertedAlarm = new PositiveAlarmDto();
            }
            else if (anAlarm.GetType().Name.Equals("AuthorAlarm"))
            {
                AuthorAlarm authorAlarm = (AuthorAlarm)anAlarm;
                convertedAlarm = new AuthorAlarmDto()
                {
                    PhrasesType = authorAlarm.PhrasesType
                };
            }
            else
            {
                convertedAlarm = new NegativeAlarmDto();
            }
            convertedAlarm.AlarmDtoId = anAlarm.AlarmId;
            convertedAlarm.Active = anAlarm.Active;
            convertedAlarm.Entity = ConvertToDto(anAlarm.Entity);
            convertedAlarm.RequiredPostQuantity = anAlarm.RequiredPostQuantity;
            convertedAlarm.TimeFrame = anAlarm.TimeFrame;
            return convertedAlarm;
        }

        public Alarm ConvertToObject(AlarmDto anAlarm)
        {
            Alarm convertedAlarm;
            if (anAlarm.GetType().Name.Equals("PositiveAlarmDto"))
            {
                convertedAlarm = new PositiveAlarm(ConvertToObject(anAlarm.Entity),
                                                   anAlarm.RequiredPostQuantity,
                                                   new TimeSpan(anAlarm.TimeFrame))
                {
                    Active = anAlarm.Active
                };
            }
            else if (anAlarm.GetType().Name.Equals("AuthorAlarmDto"))
            {
                AuthorAlarmDto authorAlarm = (AuthorAlarmDto)anAlarm;
                convertedAlarm = new AuthorAlarm(ConvertToObject(anAlarm.Entity),
                                                 anAlarm.RequiredPostQuantity,
                                                 new TimeSpan(anAlarm.TimeFrame),
                                                 authorAlarm.PhrasesType)
                {
                    Active = anAlarm.Active
                };
            }
            else
            {
                convertedAlarm = new NegativeAlarm(ConvertToObject(anAlarm.Entity),
                                                   anAlarm.RequiredPostQuantity,
                                                   new TimeSpan(anAlarm.TimeFrame))
                {
                    Active = anAlarm.Active
                };
            }
            convertedAlarm.AlarmId = anAlarm.AlarmDtoId;
            return convertedAlarm;
        }
    }
}
