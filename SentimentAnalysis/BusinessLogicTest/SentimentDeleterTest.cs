using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class SentimentDeleterTest
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
            SentimentAdder adder = new SentimentAdder(Data, "name", true);
            SentimentAdder adder2 = new SentimentAdder(Data, "aname", true);
        }
        [TestMethod]
        public void NewEntityDeleterTest()
        {
            Sentiment sentiment = new PositiveSentiment("name");
            int idFix = 2;
            sentiment.SentimentId = sentiment.SentimentId - idFix;
            SentimentDeleter deleter = new SentimentDeleter(Data, sentiment);
            Assert.IsNotNull(deleter);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteEntityTest()
        {
            Sentiment sentiment = new PositiveSentiment("aname1");
            int idFix = 2;
            sentiment.SentimentId = sentiment.SentimentId - idFix;
            SentimentDeleter deleter = new SentimentDeleter(Data, sentiment);
            Data.sentimentSaver.FetchSentiment(sentiment);
        }
        
    }
}
