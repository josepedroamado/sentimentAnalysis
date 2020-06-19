using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationAdderTest
    {
        SystemData Data;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver EntitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            Data = new SystemData(EntitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver);
        }

        [TestMethod]
        public void NewPublicationAdderTest()
        {
            DateTime date = new DateTime();
            PublicationAdder adder = new PublicationAdder(Data, "text", date);
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddPublicationTest()
        {
            DateTime date = new DateTime();
            PublicationAdder adder = new PublicationAdder(Data, "sometext", date);
            Assert.AreEqual(1, Data.publicationSaver.FetchAll().Count);
        }
    }
}

