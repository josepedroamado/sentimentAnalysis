using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
