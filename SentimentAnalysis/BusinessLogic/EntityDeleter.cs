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
            data.entitySaver.Delete(entityToDelete);
        }
    }
}
