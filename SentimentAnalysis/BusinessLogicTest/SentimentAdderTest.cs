using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class SentimentAdderTest
    {
        SystemData data;
        SentimentAdder adder;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
            adder = new SentimentAdder(data);
        }

        [TestMethod]
        public void NewSentimentAdderTest()
        {
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddSentimentTest()
        {
            adder.Add("sometext", true);
            Assert.AreEqual("sometext", data.sentimentSaver.FetchAll()[0].Text);
        }

        [TestMethod]
        public void AddSentimentNegativeTest()
        {
            adder.Add("sometext", false);
            Sentiment expectedSentiment = new NegativeSentiment("sometext");
            Assert.AreEqual(expectedSentiment.GetType(), data.sentimentSaver.FetchAll()[0].GetType());
        }
    }
}
