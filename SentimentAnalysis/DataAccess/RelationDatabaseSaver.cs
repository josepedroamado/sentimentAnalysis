using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RelationDatabaseSaver : IRelationSaver
    {
        public void AddRelation(Relation aRelation)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if (context.Relations.Any(relation => relation.Entity.EntityDtoId == aRelation.Entity.EntityId
                                                   && relation.Publication.PublicationDtoId == aRelation.Publication.PublicationId
                                                   && relation.Sentiment.SentimentDtoId == aRelation.Sentiment.SentimentId))
                {
                    throw new ObjectAlreadyExistsException("Relacion");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    RelationDto newRelation = convert.ConvertToDto(aRelation);
                    context.Relations.Add(newRelation);
                    context.SaveChanges();
                    aRelation.RelationId = newRelation.RelationDtoId;
                }
            }
        }

        public void DeleteRelation(Relation aRelation)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto relationToDelete = context.Relations.FirstOrDefault(relation => relation.RelationDtoId == aRelation.RelationId);
                if (relationToDelete == null)
                {
                    throw new ObjectDoesntExistException("Relacion");
                }
                else
                {
                    context.Relations.Remove(relationToDelete);
                    context.SaveChanges();
                }
            }
        }

        public List<Relation> FetchAll()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                List<Relation> allRelations = new List<Relation>();
                foreach (RelationDto relation in context.Relations)
                {
                    ObjectConversion convert = new ObjectConversion();
                    allRelations.Add(convert.ConvertToObject(relation));
                }
                return allRelations;
            }
        }

        public List<Publication> FetchAllPublicationsOfEntity(int entityId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                List<Publication> allPublications = new List<Publication>();
                foreach (RelationDto relation in context.Relations)
                {
                    if (relation.Entity.EntityDtoId == entityId)
                    {
                        ObjectConversion convert = new ObjectConversion();
                        allPublications.Add(convert.ConvertToObject(relation.Publication));
                    }
                }
                return allPublications;
            }
        }

        public Relation FetchRelation(Relation aRelation)
        {
            return FetchRelation(aRelation.RelationId);
        }

        public Relation FetchRelation(int publicationId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto fetchedRelation = context.Relations.FirstOrDefault(relation => relation.RelationDtoId == publicationId);
                if (fetchedRelation == null)
                {
                    throw new ObjectDoesntExistException("Relacion");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    return convert.ConvertToObject(fetchedRelation);
                }
            }
        }

        public void ModifyRelation(Relation original, Relation modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto fetchedRelation = context.Relations.FirstOrDefault(relation => relation.RelationDtoId == original.RelationId);
                if (fetchedRelation == null)
                {
                    throw new ObjectDoesntExistException("Relacion");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    fetchedRelation.Entity = convert.ConvertToDto(modified.Entity);
                    fetchedRelation.Publication = convert.ConvertToDto(modified.Publication);
                    fetchedRelation.Sentiment = convert.ConvertToDto(modified.Sentiment);
                    context.SaveChanges();
                }
            }
        }

        public void Clear()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                context.Relations.RemoveRange(context.Relations);
                context.SaveChanges();
            }
        }
    }
}
