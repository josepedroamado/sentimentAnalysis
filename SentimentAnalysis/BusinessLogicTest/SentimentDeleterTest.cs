using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class SentimentDeleterTest
    {
        SystemData data;
        SentimentDeleter deleter;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
            SentimentAdder adder = new SentimentAdder(data);
            adder.Add("name", true);
            adder.Add("aname", true);
            deleter = new SentimentDeleter(data);
        }

        [TestMethod]
        public void NewSentimentDeleterTest()
        {
            Assert.IsNotNull(deleter);
        }

        [TestMethod]
        public void DeleteSentimentTest()
        {
            Sentiment sentiment = new PositiveSentiment("aname");
            deleter.Delete(sentiment);
            Assert.AreEqual(1, data.sentimentSaver.FetchAll().Count);
        }
        
    }
}
