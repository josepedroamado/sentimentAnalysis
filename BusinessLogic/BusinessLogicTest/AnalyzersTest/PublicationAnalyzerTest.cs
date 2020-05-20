using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationAnalyzerTest
    {
        IPublicationSaver publicationSaver;
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

        [TestInitialize]
        public void TestInitialize()
        {
            publicationSaver = new InMemoryPublication();
            firstDateTime = new DateTime(2020, 01, 01);
            firstPublication = new Publication("Me gusta Coca-cola", firstDateTime);
            publicationSaver.AddPublication(firstPublication);
            secondDateTime = new DateTime(2020, 01, 11);
            secondPublication = new Publication("Odio Pepsi", secondDateTime);
            publicationSaver.AddPublication(secondPublication);
            thirdDateTime = new DateTime(2020, 01, 21);
            thirdPublication = new Publication("No me banco a Claro", thirdDateTime);

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

            publicationAnalyzer = new PublicationAnalyzer();
        }

        [TestMethod]
        public void NewPublicationAnalyzer()
        {
            Assert.IsNotNull(publicationAnalyzer);
        }
    }
}
