using System.Collections.Generic;

namespace BusinessLogic
{
    public class EntityDeleter
    {
        private SystemData data;

        public EntityDeleter(SystemData data)
        {
            this.data = data;
        }

        public void Delete(Entity entityToDelete)
        {
            if (entityToDelete != null)
            {
                List<Relation> relations = data.relationSaver.FetchAllWithEntity(entityToDelete.EntityId);
                foreach (Relation relationToDelete in relations)
                {
                    data.relationSaver.Delete(relationToDelete);
                }

                List<Alarm> alarms = data.alarmSaver.FetchAllOfEntity(entityToDelete.EntityId);
                foreach (Alarm alarmToDelete in alarms)
                {
                    data.alarmSaver.Delete(alarmToDelete);
                }
                data.entitySaver.Delete(entityToDelete);
            }
        }
    }
}
