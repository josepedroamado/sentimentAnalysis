using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemorySentimentTest
    {
        ISentimentSaver sentimentSaver;
        Sentiment aSentiment;

        [TestInitialize]
        public void TestInitialize()
        {
            sentimentSaver = new InMemorySentiment();
            aSentiment = new PositiveSentiment("InMemorySentimentTest1" );
        }
        [TestMethod]
        public void NewInMemorySentimentTest()
        {
            Assert.IsNotNull(sentimentSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewInMemorySentimentTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            sentimentSaver.AddSentiment(aSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void SentimentWithThatTextAlreadyExistsTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            Sentiment sentiment = new PositiveSentiment("InMemorySentimentTest1");
            sentimentSaver.AddSentiment(sentiment);
        }

        [TestMethod]
        public void DeleteExistingSentimentTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            sentimentSaver.DeleteSentiment(aSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingSentimentTest()
        {
            sentimentSaver.DeleteSentiment(aSentiment);
            Assert.IsNotNull(sentimentSaver);
        }

        [TestMethod]
        public void FetchExistingSentimentByObjectTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(aSentiment);
            Assert.IsNotNull(fetchedSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentByObjectTest()
        {
            Assert.IsNotNull(sentimentSaver.FetchSentiment(aSentiment));
        }

        [TestMethod]
        public void FetchExistingSentimentByIdTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(aSentiment.SentimentId);
            Assert.IsNotNull(fetchedSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentByIdTest()
        {
            Assert.IsNotNull(sentimentSaver.FetchSentiment(aSentiment.SentimentId));
        }

        [TestMethod]
        public void ModifyExistingSentimentTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.ModifySentiment(aSentiment, modifiedSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(aSentiment);
            Assert.AreEqual(fetchedSentiment.Text, modifiedSentiment.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingSentimentTest()
        {
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.ModifySentiment(aSentiment, modifiedSentiment);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            sentimentSaver.AddSentiment(aSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(aSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
