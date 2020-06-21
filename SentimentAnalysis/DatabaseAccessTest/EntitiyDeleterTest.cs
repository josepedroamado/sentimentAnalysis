using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class EntitiyDeleterTest
    {
        SystemData data;
        EntityDeleter deleter;

        [TestInitialize]
        public void TestInitialize()
        {
            IAuthorSaver authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            IAlarmSaver alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            IRelationSaver relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            IPublicationSaver publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            IEntitySaver entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            ISentimentSaver sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);
            EntityAdder adder = new EntityAdder(data);
            adder.Add("name");
            adder.Add("aname");
            deleter = new EntityDeleter(data);
        }

        [TestMethod]
        public void NewEntityDeleterTest()
        {
            Assert.IsNotNull(deleter);
        }

        [TestMethod]
        public void DeleteEntityTest()
        {
            Entity entity = new Entity("name");
            deleter.Delete(entity);
            Assert.AreEqual(1, data.entitySaver.FetchAll().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingEntityTest()
        {
            Entity entity = new Entity("aname2");
            deleter.Delete(entity);
            data.entitySaver.Fetch(entity);
        }
    }
}
