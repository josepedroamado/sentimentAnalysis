using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class SentimentAdderTest
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
        public void NewSentimentAdderTest()
        {
            SentimentAdder adder = new SentimentAdder(Data, "text",  true);
            Assert.IsNotNull(adder);
        }
        [TestMethod]
        public void AddSentimentTest()
        {
            SentimentAdder adder = new SentimentAdder(Data, "sometext", true);
            Sentiment expectedSentiment = new PositiveSentiment("sometext");
            Assert.AreEqual(expectedSentiment.Text, Data.sentimentSaver.FetchAll()[0].Text);
        }
        [TestMethod]
        public void AddSentimentNegativeTest()
        {
            SentimentAdder adder = new SentimentAdder(Data, "sometext", false);
            Sentiment expectedSentiment = new NegativeSentiment("sometext");
            Assert.AreEqual(expectedSentiment.GetType(), Data.sentimentSaver.FetchAll()[0].GetType());
        }
    }
}
