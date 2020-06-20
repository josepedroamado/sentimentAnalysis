using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationAdderTest
    {
        SystemData data;
        PublicationAdder adder;
        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
            adder = new PublicationAdder(data);
            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);
        }

        [TestMethod]
        public void NewPublicationAdderTest()
        {
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddPublicationTest()
        {
            DateTime date = new DateTime();
            adder.Add("sometext", date, anAuthor);
            Assert.AreEqual(1, data.publicationSaver.FetchAll().Count);
        }
    }
}

