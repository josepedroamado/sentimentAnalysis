using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            IRelationSaver relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            IPublicationSaver publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            IAuthorSaver authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            IAlarmSaver alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            IEntitySaver entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            ISentimentSaver sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();

            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);
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
            Assert.AreEqual("sometext", data.sentimentSaver.FetchAll()[1].Text);
        }

        [TestMethod]
        public void AddSentimentNegativeTest()
        {
            adder.Add("sometext", false);
            Sentiment expectedSentiment = new NegativeSentiment("sometext");
            Assert.AreEqual(expectedSentiment.GetType(), data.sentimentSaver.FetchAll()[1].GetType());
        }
    }
}
