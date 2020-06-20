using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityAdderTest
    {
        SystemData data;
        EntityAdder adder;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
            adder = new EntityAdder(data);
        }

        [TestMethod]
        public void NewEntityAdderTest()
        {
            adder.Add("text");
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddTest()
        {
            adder.Add("sometext");
            Entity expectedEntity = new Entity("sometext");
            Assert.AreEqual(expectedEntity.Name , data.entitySaver.FetchAll()[0].Name);
        }
    }
}
