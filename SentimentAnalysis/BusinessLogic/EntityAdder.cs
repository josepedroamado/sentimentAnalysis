using System;

namespace BusinessLogic
{
    public class EntityAdder
    {
        private SystemData data;

        public EntityAdder(SystemData data)
        {
            this.data = data;
        }

        public void Add(String Name)
        {
            Entity newEntity = new Entity(Name);
            data.entitySaver.Add(newEntity);
        }
    }
}
