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
        Author anAuthor;

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

            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);
        }

        [TestMethod]
        public void NewRelationAdderTest()
        {
            Assert.IsNotNull(relationAdder);
        }

        [TestMethod]
        public void AddRelationTest()
        {
            Publication publication = new Publication("Amo Coca-Cola.", DateTime.Now, anAuthor);
            relationAdder.AddRelation(publication);
            Assert.AreEqual(publication, data.relationSaver.FetchAll()[0].Publication);
        }
    }
}
