using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class SystemDataTest
    {
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;
        IRelationSaver relationSaver;
        IAlarmSaver alarmSaver;
        SystemData systemData;

        [TestInitialize]
        public void TestInitialize()
        {
            entitySaver = new InMemoryEntity();
            sentimentSaver = new InMemorySentiment();
            publicationSaver = new InMemoryPublication();
            relationSaver = new InMemoryRelation();
            alarmSaver = new InMemoryAlarm();
            systemData = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver);
        }

        [TestMethod]
        public void NewSystemDataTest()
        {
            Assert.IsNotNull(systemData);
        }
    }
}
