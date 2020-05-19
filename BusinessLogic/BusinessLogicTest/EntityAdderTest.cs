using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityAdderTest
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
        }
        [TestMethod]
        public void NewEntityAdderTest()
        {
            EntityAdder adder = new EntityAdder(Data, "text");
            Assert.IsNotNull(adder);
        }
        [TestMethod]
        public void AddEntityTest()
        {
            EntityAdder adder = new EntityAdder(Data, "sometext");
            Entity expectedEntity = new Entity("sometext");
            Assert.AreEqual(expectedEntity.Name , Data.entitySaver.FetchAll()[0].Name);
        }
    }
}
