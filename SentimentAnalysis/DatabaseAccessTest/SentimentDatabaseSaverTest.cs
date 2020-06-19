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
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(positiveSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void SentimentWithThatTextAlreadyExistsTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            Sentiment sentiment = new PositiveSentiment("PositiveSentimentTest1");
            sentimentSaver.AddSentiment(sentiment);
        }

        [TestMethod]
        public void DeleteExistingSentimentTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.DeleteSentiment(positiveSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingSentimentTest()
        {
            sentimentSaver.DeleteSentiment(positiveSentiment);
            Assert.IsNotNull(sentimentSaver);
        }

        [TestMethod]
        public void FetchExistingSentimentByObjectTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(positiveSentiment);
            Assert.IsNotNull(fetchedSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentByObjectTest()
        {
            Assert.IsNotNull(sentimentSaver.FetchSentiment(positiveSentiment));
        }

        [TestMethod]
        public void FetchExistingSentimentByIdTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(positiveSentiment);
            Sentiment fetchedSentimentById = sentimentSaver.FetchSentiment(fetchedSentiment.SentimentId);
            Assert.IsNotNull(fetchedSentimentById);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentByIdTest()
        {
            Assert.IsNotNull(sentimentSaver.FetchSentiment(positiveSentiment.SentimentId));
        }

        [TestMethod]
        public void ModifyExistingSentimentTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedPositiveSentimentTest");
            sentimentSaver.ModifySentiment(positiveSentiment, modifiedSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(modifiedSentiment);
            Assert.AreEqual(fetchedSentiment.Text, modifiedSentiment.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingSentimentTest()
        {
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedPositiveSentimentTest");
            sentimentSaver.ModifySentiment(positiveSentiment, modifiedSentiment);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(negativeSentiment);
            Assert.AreEqual(2, sentimentSaver.FetchAll().Count());
        }

        [TestMethod]
        public void FetchAllPositiveSentimentTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(negativeSentiment);
            Assert.AreEqual(1, sentimentSaver.FetchAllPositiveSentiments().Count());
        }

        [TestMethod]
        public void FetchAllNegativeSentimentTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(negativeSentiment);
            Assert.AreEqual(1, sentimentSaver.FetchAllNegativeSentiments().Count());
        }
    }
}
