using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EntityDatabaseSaver : IEntitySaver
    {
        public void AddEntity(Entity anEntity)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if(context.Entities.Any(entity => entity.EntityDtoId == anEntity.EntityId || entity.Name == anEntity.Name))
                {
                    throw new ObjectAlreadyExistsException("Entidad");
                }
                else
                {
                    EntityDto newEntity = ConvertToDto(anEntity);
                    context.Entities.Add(newEntity);
                    context.SaveChanges();
                    anEntity.EntityId = newEntity.EntityDtoId;
                }
            }
        }

        private EntityDto ConvertToDto(Entity anEntity)
        {
            EntityDto convertedEntity = new EntityDto();
            convertedEntity.EntityDtoId = anEntity.EntityId;
            convertedEntity.Name = anEntity.Name;
            return convertedEntity;
        }

        public void DeleteEntity(Entity anEntity)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                EntityDto entityToDelete = context.Entities.First(entitiy => entitiy.EntityDtoId == anEntity.EntityId);
                if(entityToDelete == null)
                {
                    throw new ObjectDoesntExistException("Entity");
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
                    allEntities.Add(ConvertToObject(entity));
                }
                return allEntities;
            }
        }

        public Entity FetchEntity(Entity anEntity)
        {
            return FetchEntity(anEntity.EntityId);
        }

        public Entity FetchEntity(int entityId)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                EntityDto fetchedEntity = context.Entities.First(entitiy => entitiy.EntityDtoId == entityId);
                if (fetchedEntity == null)
                {
                    throw new ObjectDoesntExistException("Entity");
                }
                else
                {
                    return ConvertToObject(fetchedEntity);
                }
            }
        }

        private Entity ConvertToObject(EntityDto anEntityDto)
        {
            Entity convertedEntity = new Entity(anEntityDto.Name);
            convertedEntity.EntityId = anEntityDto.EntityDtoId;
            return convertedEntity;
        }

        public void ModifyEntity(Entity original, Entity modified)
        {
            throw new NotImplementedException();
        }
    }
}
