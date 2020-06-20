using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationAdderTest
    {
        SystemData Data;
        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver EntitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            Data = new SystemData(EntitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver);

            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);
        }
        [TestMethod]
        public void NewPublicationAdderTest()
        {
            DateTime date = new DateTime();
            PublicationAdder adder = new PublicationAdder(Data, "text", date, anAuthor);
            Assert.IsNotNull(adder);
        }
        [TestMethod]
        public void AddPublicationTest()
        {
            DateTime date = new DateTime();
            PublicationAdder adder = new PublicationAdder(Data, "sometext", date, anAuthor);
            Publication expectedPublication = new Publication("sometext", date, anAuthor);
            expectedPublication.PublicationId = expectedPublication.PublicationId - 1;
            Assert.AreEqual(expectedPublication.Phrase, Data.publicationSaver.FetchPublication(expectedPublication).Phrase);
        }
    }
}

