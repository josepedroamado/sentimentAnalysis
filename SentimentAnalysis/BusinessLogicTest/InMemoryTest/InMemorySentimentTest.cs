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
        Sentiment positiveSentiment;
        Sentiment negativeSentiment;

        [TestInitialize]
        public void TestInitialize()
        {
            sentimentSaver = new InMemorySentiment();
            sentimentSaver.Clear();
            positiveSentiment = new PositiveSentiment("InMemorySentimentTest1" );
            negativeSentiment = new NegativeSentiment("InMemorySentimentTest2");
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
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(positiveSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void SentimentWithThatTextAlreadyExistsTest()
        {
            sentimentSaver.Add(positiveSentiment);
            Sentiment sentiment = new PositiveSentiment("InMemorySentimentTest1");
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
            Sentiment fetchedSentiment = sentimentSaver.Fetch(positiveSentiment.SentimentId);
            Assert.IsNotNull(fetchedSentiment);
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
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.Modify(positiveSentiment, modifiedSentiment);
            Sentiment fetchedSentiment = sentimentSaver.Fetch(positiveSentiment);
            Assert.AreEqual(fetchedSentiment.Text, modifiedSentiment.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingSentimentTest()
        {
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.Modify(positiveSentiment, modifiedSentiment);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(negativeSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(positiveSentiment);
            expectedList.Add(negativeSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }

        [TestMethod]
        public void FetchAllPositiveSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(negativeSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(positiveSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAllPositive();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }

        [TestMethod]
        public void FetchAllNegativeSentimentTest()
        {
            sentimentSaver.Add(positiveSentiment);
            sentimentSaver.Add(negativeSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(negativeSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAllNegative();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
