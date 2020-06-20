using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class EntityDatabaseSaver : IEntitySaver
    {
        public void Add(Entity anEntity)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if(context.Entities.Any(entity => entity.EntityDtoId.Equals(anEntity.EntityId) || entity.Name == anEntity.Name))
                {
                    throw new ObjectAlreadyExistsException("Entidad");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    EntityDto newEntity = convert.ConvertToDto(anEntity);
                    context.Entities.Add(newEntity);
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Entity anEntity)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                EntityDto entityToDelete = context.Entities.FirstOrDefault(entitiy => entitiy.EntityDtoId.Equals(anEntity.EntityId) || entitiy.Name == anEntity.Name);
                if(entityToDelete == null)
                {
                    throw new ObjectDoesntExistException("Entidad");
                }
                else
                {
                    context.Entities.Remove(entityToDelete);
                    context.SaveChanges();
                }
            }
        }

        public List<Entity> FetchAll()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                List<Entity> allEntities = new List<Entity>();
                foreach (EntityDto entity in context.Entities)
                {
                    ObjectConversion convert = new ObjectConversion();
                    allEntities.Add(convert.ConvertToObject(entity));
                }
                return allEntities;
            }
        }

        public Entity Fetch(Entity anEntity)
        {
            return Fetch(anEntity.EntityId);
        }

        public Entity Fetch(Guid entityId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                EntityDto fetchedEntity = context.Entities.FirstOrDefault(entitiy => entitiy.EntityDtoId.Equals(entityId));
                if (fetchedEntity == null)
                {
                    throw new ObjectDoesntExistException("Entidad");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    return convert.ConvertToObject(fetchedEntity);
                }
            }
        }

        public void Modify(Entity original, Entity modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                EntityDto fetchedEntity = context.Entities.FirstOrDefault(entitiy => entitiy.EntityDtoId.Equals(original.EntityId));
                if (fetchedEntity == null)
                {
                    throw new ObjectDoesntExistException("Entidad");
                }
                else
                {
                    fetchedEntity.Name = modified.Name;
                    context.SaveChanges();
                }
            }
        }

        public void Clear()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                context.Entities.RemoveRange(context.Entities);
                context.SaveChanges();
            }
        }
    }
}
