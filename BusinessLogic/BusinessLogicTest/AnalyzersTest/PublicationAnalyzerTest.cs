using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationAnalyzerTest
    {
        DateTime firstDateTime;
        Publication firstPublication;
        DateTime secondDateTime;
        Publication secondPublication;
        DateTime thirdDateTime;
        Publication thirdPublication;

        ISentimentSaver sentimentSaver;
        Sentiment firstPositiveSentiment;
        Sentiment secondPositiveSentiment;
        Sentiment firstNegativeSentiment;
        Sentiment secondNegativeSentiment;

        IEntitySaver entitySaver;
        Entity firstEntity;
        Entity secondEntity;

        PublicationAnalyzer publicationAnalyzer;

        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);

            firstDateTime = new DateTime(2020, 01, 01);
            firstPublication = new Publication("Me gusta Coca-cola", firstDateTime, anAuthor);
            secondDateTime = new DateTime(2020, 01, 11);
            secondPublication = new Publication("Odio Pepsi", secondDateTime, anAuthor);
            thirdDateTime = new DateTime(2020, 01, 21);
            thirdPublication = new Publication("No me banco a Claro", thirdDateTime, anAuthor);

            sentimentSaver = new InMemorySentiment();
            firstPositiveSentiment = new PositiveSentiment("Me gusta");
            sentimentSaver.AddSentiment(firstPositiveSentiment);
            secondPositiveSentiment = new PositiveSentiment("Amo");
            sentimentSaver.AddSentiment(secondPositiveSentiment);
            firstNegativeSentiment = new NegativeSentiment("Odio");
            sentimentSaver.AddSentiment(firstNegativeSentiment);
            secondNegativeSentiment = new NegativeSentiment("Me desagrada");
            sentimentSaver.AddSentiment(secondNegativeSentiment);

            entitySaver = new InMemoryEntity();
            firstEntity = new Entity("Coca-cola");
            entitySaver.AddEntity(firstEntity);
            secondEntity = new Entity("Pepsi");
            entitySaver.AddEntity(secondEntity);

            publicationAnalyzer = new PublicationAnalyzer(sentimentSaver, entitySaver);
        }

        [TestMethod]
        public void NewPublicationAnalyzer()
        {
            Assert.IsNotNull(publicationAnalyzer);
        }

        [TestMethod]
        public void AnalyzeCorrectFirstEntityTest()
        {
            Entity detectedEntity = publicationAnalyzer.AnalyzeEntity(firstPublication);
            Assert.AreEqual(firstEntity, detectedEntity);
        }

        [TestMethod]
        public void AnalyzeCorrectSecondEntityTest()
        {
            Entity detectedEntity = publicationAnalyzer.AnalyzeEntity(secondPublication);
            Assert.AreEqual(secondEntity, detectedEntity);
        }

        [TestMethod]
        public void AnalyzeIncorrectEntityTest()
        {
            Entity detectedEntity = publicationAnalyzer.AnalyzeEntity(thirdPublication);
            Assert.IsNull(detectedEntity);
        }

        [TestMethod]
        public void AnalyzeCorrectFirstPositiveSentimentTest()
        {
            Sentiment detectedSentiment = publicationAnalyzer.AnalyzeSentiment(firstPublication);
            Assert.AreEqual(firstPositiveSentiment, detectedSentiment);
        }

        [TestMethod]
        public void AnalyzeCorrectFirstNegativeSentimentTest()
        {
            Sentiment detectedSentiment = publicationAnalyzer.AnalyzeSentiment(secondPublication);
            Assert.AreEqual(firstNegativeSentiment, detectedSentiment);
        }

        [TestMethod]
        public void AnalyzeIncorrectSentimentTest()
        {
            Sentiment detectedSentiment = publicationAnalyzer.AnalyzeSentiment(thirdPublication);
            Assert.IsNull(detectedSentiment);
        }

        [TestMethod]
        public void AnalyzeFirstPublicationTest()
        {
            Relation detectedRelation = publicationAnalyzer.AnalyzePublication(firstPublication);
            Relation expectedRelation = new Relation(firstPublication, firstPositiveSentiment, firstEntity);
            Assert.AreEqual(detectedRelation.Publication, expectedRelation.Publication);
            Assert.AreEqual(detectedRelation.Sentiment, expectedRelation.Sentiment);
            Assert.AreEqual(detectedRelation.Entity, expectedRelation.Entity);
        }

        [TestMethod]
        public void AnalyzeSecondPublicationTest()
        {
            Relation detectedRelation = publicationAnalyzer.AnalyzePublication(secondPublication);
            Relation expectedRelation = new Relation(secondPublication, firstNegativeSentiment, secondEntity);
            Assert.AreEqual(detectedRelation.Publication, expectedRelation.Publication);
            Assert.AreEqual(detectedRelation.Sentiment, expectedRelation.Sentiment);
            Assert.AreEqual(detectedRelation.Entity, expectedRelation.Entity);
        }

        [TestMethod]
        public void AnalyzeNoSentimentNoEntityPublicationTest()
        {
            Relation detectedRelation = publicationAnalyzer.AnalyzePublication(thirdPublication);
            Relation expectedRelation = new Relation(thirdPublication, null, null);
            Assert.AreEqual(detectedRelation.Publication, expectedRelation.Publication);
            Assert.AreEqual(detectedRelation.Sentiment, expectedRelation.Sentiment);
            Assert.AreEqual(detectedRelation.Entity, expectedRelation.Entity);
        }
    }
}
