using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class RelationDatabaseSaver : IRelationSaver
    {
        public void Add(Relation aRelation)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                ObjectConversion convert = new ObjectConversion();
                RelationDto newRelation = convert.ConvertToDto(aRelation);
                if (context.Relations.Include("Entity").Include("Publication").Include("Sentiment")
                        .Any(relation => relation.Entity.Name == newRelation.Entity.Name
                                      && relation.Publication.Phrase == newRelation.Publication.Phrase
                                      && relation.Sentiment.Text == newRelation.Sentiment.Text))
                {
                    throw new ObjectAlreadyExistsException("Relacion");
                }
                else
                {
                    context.Relations.Add(newRelation);
                    context.Entry(newRelation.Entity).State = EntityState.Unchanged;
                    context.Entry(newRelation.Publication).State = EntityState.Unchanged;
                    context.Entry(newRelation.Sentiment).State = EntityState.Unchanged;
                    context.SaveChanges();
                }                    
            }
        }

        public void Delete(Relation aRelation)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto relationToDelete = context.Relations.Include("Entity").Include("Publication").Include("Sentiment").FirstOrDefault(relation => relation.RelationDtoId.Equals(aRelation.RelationId));
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
                ObjectConversion convert = new ObjectConversion();
                foreach (RelationDto relation in context.Relations.Include("Entity").Include("Publication").Include("Sentiment"))
                {
                    allRelations.Add(convert.ConvertToObject(relation));
                }
                return allRelations;
            }
        }

        public List<Publication> FetchAllPublicationsOfEntity(Guid entityId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                List<Publication> allPublications = new List<Publication>();
                foreach (RelationDto relation in context.Relations.Include("Entity").Include("Publication").Include("Sentiment"))
                {
                    if (relation.Entity.EntityDtoId.Equals(entityId))
                    {
                        ObjectConversion convert = new ObjectConversion();
                        allPublications.Add(convert.ConvertToObject(relation.Publication));
                    }
                }
                return allPublications;
            }
        }

        public Relation Fetch(Relation aRelation)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto fetchedRelation = context.Relations.Include("Entity").Include("Publication").Include("Sentiment")
                    .FirstOrDefault(relation => relation.RelationDtoId.Equals(aRelation.RelationId));
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

        public Relation Fetch(Guid publicationId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto fetchedRelation = context.Relations.Include("Entity").Include("Publication").Include("Sentiment")
                                                               .FirstOrDefault(relation => relation.Publication.PublicationDtoId.Equals(publicationId));
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

        public void Modify(Relation original, Relation modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                RelationDto fetchedRelation = context.Relations.Include("Entity").Include("Publication").Include("Sentiment").FirstOrDefault(relation => relation.RelationDtoId.Equals(original.RelationId));
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
