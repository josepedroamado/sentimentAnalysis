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
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(positiveSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void SentimentWithThatTextAlreadyExistsTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            Sentiment sentiment = new PositiveSentiment("InMemorySentimentTest1");
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
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(positiveSentiment.SentimentId);
            Assert.IsNotNull(fetchedSentiment);
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
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.ModifySentiment(positiveSentiment, modifiedSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(positiveSentiment);
            Assert.AreEqual(fetchedSentiment.Text, modifiedSentiment.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingSentimentTest()
        {
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.ModifySentiment(positiveSentiment, modifiedSentiment);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(negativeSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(positiveSentiment);
            expectedList.Add(negativeSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }

        [TestMethod]
        public void FetchAllPositiveSentimentTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(negativeSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(positiveSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAllPositiveSentiments();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }

        [TestMethod]
        public void FetchAllNegativeSentimentTest()
        {
            sentimentSaver.AddSentiment(positiveSentiment);
            sentimentSaver.AddSentiment(negativeSentiment);
            List<Sentiment> expectedList = new List<Sentiment>();
            expectedList.Add(negativeSentiment);
            List<Sentiment> actualList = sentimentSaver.FetchAllNegativeSentiments();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
