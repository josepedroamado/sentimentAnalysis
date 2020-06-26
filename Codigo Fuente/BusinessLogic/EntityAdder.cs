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

        public void Add(String name)
        {
            Entity newEntity = new Entity(name);
            data.entitySaver.Add(newEntity);
        }
    }
}
