using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class RelationAdderTest
    {
        SystemData data;
        RelationAdder relationAdder;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver EntitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(EntitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver);
            relationAdder = new RelationAdder(data);
        }

        [TestMethod]
        public void NewRelationAdderTest()
        {
            Assert.IsNotNull(relationAdder);
        }

        [TestMethod]
        public void AddRelationTest()
        {
            Publication publication = new Publication("Amo Coca-Cola.", DateTime.Now);
            relationAdder.AddRelation(publication);
            Assert.AreEqual(publication, data.relationSaver.FetchAll()[0].Publication);
        }
    }
}
