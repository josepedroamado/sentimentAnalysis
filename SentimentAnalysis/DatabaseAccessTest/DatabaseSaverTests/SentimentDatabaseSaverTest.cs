using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class SentimentDatabaseSaverTest
    {
        IAlarmSaver alarmSaver;
        IRelationSaver relationSaver;
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;
        IAuthorSaver authorSaver;
        Sentiment positiveSentiment;
        Sentiment negativeSentiment;

        [TestInitialize]
        public void TestInitialize()
        {
            alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
            authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            positiveSentiment = new PositiveSentiment("PositiveSentimentTest1");
            negativeSentiment = new NegativeSentiment("NegativeSentimentTest1");
        }
        [TestMethod]
        public void NewSentimentDatabaseTest()
        {
            Assert.IsNotNull(sentimentSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(positiveSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void SentimentWithThatTextAlreadyExistsTest()
        {
            sentimentSaver.Add(positiveSentiment);
            Sentiment sentiment = new PositiveSentiment("PositiveSentimentTest1");
            sentimentSaver.Add(sentiment);
        }

        [TestMethod]
        public void DeleteExistingSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Delete(positiveSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingSentimentTest()
        {
            sentimentSaver.Delete(positiveSentiment);
            Assert.IsNotNull(sentimentSaver);
        }

        [TestMethod]
        public void FetchExistingSentimentByObjectTest()
        {
            sentimentSaver.Add(positiveSentiment);
            Sentiment fetchedSentiment = sentimentSaver.Fetch(positiveSentiment);
            Assert.IsNotNull(fetchedSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentByObjectTest()
        {
            Assert.IsNotNull(sentimentSaver.Fetch(positiveSentiment));
        }

        [TestMethod]
        public void FetchExistingSentimentByIdTest()
        {
            sentimentSaver.Add(positiveSentiment);
            Sentiment fetchedSentiment = sentimentSaver.Fetch(positiveSentiment);
            Sentiment fetchedSentimentById = sentimentSaver.Fetch(fetchedSentiment.SentimentId);
            Assert.IsNotNull(fetchedSentimentById);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentByIdTest()
        {
            Assert.IsNotNull(sentimentSaver.Fetch(positiveSentiment.SentimentId));
        }

        [TestMethod]
        public void ModifyExistingSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedPositiveSentimentTest");
            sentimentSaver.Modify(positiveSentiment, modifiedSentiment);
            Sentiment fetchedSentiment = sentimentSaver.Fetch(modifiedSentiment);
            Assert.AreEqual(fetchedSentiment.Text, modifiedSentiment.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingSentimentTest()
        {
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedPositiveSentimentTest");
            sentimentSaver.Modify(positiveSentiment, modifiedSentiment);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(negativeSentiment);
            Assert.AreEqual(2, sentimentSaver.FetchAll().Count());
        }

        [TestMethod]
        public void FetchAllPositiveSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(negativeSentiment);
            Assert.AreEqual(1, sentimentSaver.FetchAllPositive().Count());
        }

        [TestMethod]
        public void FetchAllNegativeSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(negativeSentiment);
            Assert.AreEqual(1, sentimentSaver.FetchAllNegative().Count());
        }
    }
}
