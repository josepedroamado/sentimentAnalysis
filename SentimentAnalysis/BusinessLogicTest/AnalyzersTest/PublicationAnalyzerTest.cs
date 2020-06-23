using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using DataAccess;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationAnalyzerTest
    {
        SystemData data;

        Publication firstPublication;
        Publication secondPublication;
        Publication thirdPublication;

        Sentiment firstPositiveSentiment;
        Sentiment secondPositiveSentiment;
        Sentiment firstNegativeSentiment;
        Sentiment secondNegativeSentiment;

        Entity firstEntity;
        Entity secondEntity;

        Author anAuthor;

        PublicationAnalyzer publicationAnalyzer;

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

            DateTime birthdate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", birthdate);
            authorSaver.Add(anAuthor);
            
            firstPublication = new Publication("Me gusta Coca-cola", new DateTime(2020, 01, 01), anAuthor);
            secondPublication = new Publication("Odio Pepsi", new DateTime(2020, 01, 11), anAuthor);
            thirdPublication = new Publication("No me banco a Claro", new DateTime(2020, 01, 21), anAuthor);
            publicationSaver.Add(firstPublication);
            publicationSaver.Add(secondPublication);
            publicationSaver.Add(thirdPublication);

            firstPositiveSentiment = new PositiveSentiment("Me gusta");
            sentimentSaver.Add(firstPositiveSentiment);
            secondPositiveSentiment = new PositiveSentiment("Amo");
            sentimentSaver.Add(secondPositiveSentiment);
            firstNegativeSentiment = new NegativeSentiment("Odio");
            sentimentSaver.Add(firstNegativeSentiment);
            secondNegativeSentiment = new NegativeSentiment("Me desagrada");
            sentimentSaver.Add(secondNegativeSentiment);

            firstEntity = new Entity("Coca-cola");
            entitySaver.Add(firstEntity);
            secondEntity = new Entity("Pepsi");
            entitySaver.Add(secondEntity);

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
