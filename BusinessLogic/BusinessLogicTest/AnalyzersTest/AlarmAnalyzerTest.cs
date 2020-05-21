using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class AlarmAnalyzerTest
    {
        IPublicationSaver publicationSaver;
        DateTime firstDateTime;
        Publication firstPublication;
        DateTime secondDateTime;
        Publication secondPublication;
        DateTime thirdDateTime;
        Publication thirdPublication;
        DateTime fourthDateTime;
        Publication fourthPublication;

        ISentimentSaver sentimentSaver;
        Sentiment firstPositiveSentiment;
        Sentiment secondPositiveSentiment;
        Sentiment firstNegativeSentiment;
        Sentiment secondNegativeSentiment;

        IEntitySaver entitySaver;
        Entity firstEntity;
        Entity secondEntity;
        Entity thirdEntity;

        IRelationSaver relationSaver;

        PublicationAnalyzer publicationAnalyzer;

        AlarmAnalyzer alarmAnalyzer;

        Alarm positiveActiveAlarm;
        Alarm negativeActiveAlarm;
        Alarm negativeInactiveAlarm;

    [TestInitialize]
        public void TestInitialize()
        {
            relationSaver = new InMemoryRelation();

            publicationSaver = new InMemoryPublication();
            firstDateTime = DateTime.Now.Subtract(new TimeSpan(10, 0, 0, 0));
            firstPublication = new Publication("Me gusta Coca-cola", firstDateTime);
            publicationSaver.AddPublication(firstPublication);

            fourthDateTime = DateTime.Now.Subtract(new TimeSpan(3, 0, 0, 0));
            fourthPublication = new Publication("Amo Coca-cola", fourthDateTime);
            publicationSaver.AddPublication(fourthPublication);
           
            secondDateTime = DateTime.Now.Subtract(new TimeSpan(8, 0, 0, 0));
            secondPublication = new Publication("Odio Pepsi", secondDateTime);
            publicationSaver.AddPublication(secondPublication);

            thirdDateTime = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
            thirdPublication = new Publication("Me desagrada Claro", thirdDateTime);
            publicationSaver.AddPublication(thirdPublication);       

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
            thirdEntity = new Entity("Claro");
            entitySaver.AddEntity(thirdEntity);

            publicationAnalyzer = new PublicationAnalyzer(sentimentSaver, entitySaver);
            relationSaver.AddRelation(publicationAnalyzer.AnalyzePublication(firstPublication));
            relationSaver.AddRelation(publicationAnalyzer.AnalyzePublication(secondPublication));
            relationSaver.AddRelation(publicationAnalyzer.AnalyzePublication(thirdPublication));
            relationSaver.AddRelation(publicationAnalyzer.AnalyzePublication(fourthPublication));

            alarmAnalyzer = new AlarmAnalyzer(relationSaver);

            positiveActiveAlarm = new PositiveAlarm(firstEntity, 2, new TimeSpan(11, 0, 0, 0));
            negativeActiveAlarm = new NegativeAlarm(secondEntity, 1, new TimeSpan(9, 0, 0, 0));
            negativeInactiveAlarm = new NegativeAlarm(thirdEntity, 4, new TimeSpan(5, 0, 0, 0));
        }

        [TestMethod]
        public void NewAlarmAnayzerTest()
        {
            Assert.IsNotNull(alarmAnalyzer);
        }

        [TestMethod]
        public void PositiveAlarmActiveAnalyzerTest()
        {
            alarmAnalyzer.AnalyzeAlarm(positiveActiveAlarm);
            Assert.IsTrue(positiveActiveAlarm.Active);
        }

        [TestMethod]
        public void NegativeAlarmActiveAnalyzerTest()
        {
            alarmAnalyzer.AnalyzeAlarm(negativeActiveAlarm);
            Assert.IsTrue(negativeActiveAlarm.Active);
        }

        [TestMethod]
        public void NegativeAlarmInactiveAnalyzerTest()
        {
            alarmAnalyzer.AnalyzeAlarm(negativeInactiveAlarm);
            Assert.IsFalse(negativeInactiveAlarm.Active);
        }
    }
}
