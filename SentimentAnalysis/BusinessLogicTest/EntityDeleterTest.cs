using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityDeleterTest
    {
        SystemData data;
        EntityDeleter deleter;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
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
