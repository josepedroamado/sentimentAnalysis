using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

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
        public void AddNewInMemorySentiment()
        {
            sentimentSaver.AddSentiment(aSentiment);
            sentimentSaver.AddSentiment(aSentiment);
        }

        [TestMethod]
        public void DeleteExistingSentimentInMemorySentiment()
        {
            sentimentSaver.AddSentiment(aSentiment);
            sentimentSaver.DeleteSentiment(aSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteSentimentInMemorySentiment()
        {
            sentimentSaver.DeleteSentiment(aSentiment);
            Assert.IsNotNull(sentimentSaver);
        }

        [TestMethod]
        public void FetchExistingSentimentInMemorySentiment()
        {
            sentimentSaver.AddSentiment(aSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(aSentiment);
            Assert.IsNotNull(fetchedSentiment);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingSentimentInMemorySentiment()
        {
            Assert.IsNotNull(sentimentSaver.FetchSentiment(aSentiment));
        }

        [TestMethod]
        public void ModifyExistingSentimentInMemorySentiment()
        {
            sentimentSaver.AddSentiment(aSentiment);
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.ModifySentiment(aSentiment, modifiedSentiment);
            Sentiment fetchedSentiment = sentimentSaver.FetchSentiment(aSentiment);
            Assert.AreEqual(fetchedSentiment.Text, modifiedSentiment.Text);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingSentimentInMemorySentiment()
        {
            Sentiment modifiedSentiment = new PositiveSentiment("ModifiedInMemorySentimentTest");
            sentimentSaver.ModifySentiment(aSentiment, modifiedSentiment);
        }
    }
}
