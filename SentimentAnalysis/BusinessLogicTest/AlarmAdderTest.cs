using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class AlarmAdderTest
    {
        SystemData Data;
        Boolean hours;
        Boolean positive;
        int alarmTime;
        int numberOfPosts;
        Entity entity;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver EntitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            Data = new SystemData(EntitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver);
            entity = new Entity ("aText");
            numberOfPosts = 2;
            alarmTime = 3;
            positive = true;
            hours = true;
        }

        [TestMethod]
        public void NewAlarmAdderTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, positive, hours);
            Assert.IsNotNull(addAlarm);
        }

        [TestMethod]
        public void AddAlarmEntityTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, positive, hours);
            Assert.AreEqual(1, Data.alarmSaver.FetchAll().Count);
        }

        [TestMethod]
        public void AddAlarmInDaysTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, positive, false);
            Assert.AreEqual(1, Data.alarmSaver.FetchAll().Count);
        }

        [TestMethod]
        public void AddNegativeAlarmTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, false, hours);
            Assert.AreEqual(1, Data.alarmSaver.FetchAll().Count);
        }
    }
}
