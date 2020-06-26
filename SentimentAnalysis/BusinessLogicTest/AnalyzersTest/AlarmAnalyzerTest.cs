using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using DataAccess;

namespace BusinessLogicTest
{
    [TestClass]
    public class AlarmAnalyzerTest
    {
        SystemData data;
        DateTime firstDateTime;
        Publication firstPublication;
        DateTime secondDateTime;
        Publication secondPublication;
        DateTime thirdDateTime;
        Publication thirdPublication;
        DateTime fourthDateTime;
        Publication fourthPublication;
        
        Sentiment firstPositiveSentiment;
        Sentiment secondPositiveSentiment;
        Sentiment firstNegativeSentiment;
        Sentiment secondNegativeSentiment;
        
        Entity firstEntity;
        Entity secondEntity;
        Entity thirdEntity;     

        PublicationAnalyzer publicationAnalyzer;

        AlarmAnalyzer alarmAnalyzer;

        Alarm positiveActiveAlarm;
        Alarm negativeActiveAlarm;
        Alarm negativeInactiveAlarm;

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

            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            Author anAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            authorSaver.Add(anAuthor);

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
            thirdEntity = new Entity("Claro");
            entitySaver.Add(thirdEntity);

            firstDateTime = DateTime.Now.Subtract(new TimeSpan(10, 0, 0, 0));
            firstPublication = new Publication("Me gusta Coca-cola", firstDateTime, anAuthor);
            publicationSaver.Add(firstPublication);

            fourthDateTime = DateTime.Now.Subtract(new TimeSpan(3, 0, 0, 0));
            fourthPublication = new Publication("Amo Coca-cola", fourthDateTime, anAuthor);
            publicationSaver.Add(fourthPublication);
           
            secondDateTime = DateTime.Now.Subtract(new TimeSpan(8, 0, 0, 0));
            secondPublication = new Publication("Odio Pepsi", secondDateTime, anAuthor);
            publicationSaver.Add(secondPublication);

            thirdDateTime = DateTime.Now.Subtract(new TimeSpan(1, 0, 0, 0));
            thirdPublication = new Publication("Me desagrada Claro", thirdDateTime, anAuthor);
            publicationSaver.Add(thirdPublication);

            publicationAnalyzer = new PublicationAnalyzer(sentimentSaver, entitySaver);
            relationSaver.Add(publicationAnalyzer.AnalyzePublication(firstPublication));
            relationSaver.Add(publicationAnalyzer.AnalyzePublication(secondPublication));
            relationSaver.Add(publicationAnalyzer.AnalyzePublication(thirdPublication));
            relationSaver.Add(publicationAnalyzer.AnalyzePublication(fourthPublication));

            positiveActiveAlarm = new PositiveAlarm(firstEntity, 2, new TimeSpan(11, 0, 0, 0));
            negativeActiveAlarm = new NegativeAlarm(secondEntity, 1, new TimeSpan(9, 0, 0, 0));
            negativeInactiveAlarm = new NegativeAlarm(thirdEntity, 4, new TimeSpan(5, 0, 0, 0));
            alarmSaver.Add(positiveActiveAlarm);
            alarmSaver.Add(negativeActiveAlarm);
            alarmSaver.Add(negativeInactiveAlarm);

            alarmAnalyzer = new AlarmAnalyzer(data);
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

        [TestMethod]
        public void AnalyzeAllAlarmsTest()
        {
            alarmAnalyzer.AnalyzeAllAlarms();
            Assert.IsTrue(data.alarmSaver.Fetch(positiveActiveAlarm).Active);
            Assert.IsTrue(data.alarmSaver.Fetch(negativeActiveAlarm).Active);
            Assert.IsFalse(data.alarmSaver.Fetch(negativeInactiveAlarm).Active);
        }

        [TestMethod]
        public void PositiveAlarmActiveGetAuthorsAnalyzerTest()
        {
            alarmAnalyzer.AnalyzeAlarm(positiveActiveAlarm);
            Assert.AreEqual(1, alarmAnalyzer.GetMatchingRelationsAuthors(positiveActiveAlarm).Count);
        }
    }
}
