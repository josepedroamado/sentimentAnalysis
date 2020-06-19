using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityDeleterTest
    {
        SystemData Data;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            Data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver);
            EntityAdder adder = new EntityAdder(Data, "name");
            EntityAdder adder2 = new EntityAdder(Data, "aname");
        }
        [TestMethod]
        public void NewEntityDeleterTest()
        {
            Entity entity = new Entity("name");
            EntityDeleter deleter = new EntityDeleter(Data, entity);
            Assert.IsNotNull(deleter);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteEntityTest()
        {
            Entity entity = new Entity("aname1");
            EntityDeleter deleter = new EntityDeleter(Data, entity);
            Data.entitySaver.FetchEntity(entity);
        }
    }
}
