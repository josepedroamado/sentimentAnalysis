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
            TimeSpan timeSpan = new TimeSpan(alarmTime, 0, 0);
            Alarm expectedAlarm = new PositiveAlarm(entity, numberOfPosts, timeSpan);
            expectedAlarm.AlarmId = expectedAlarm.AlarmId - 1;
            Assert.AreEqual(expectedAlarm.Entity, Data.alarmSaver.FetchAlarm(expectedAlarm).Entity);
        }
        [TestMethod]
        public void AddAlarmRequiredPostQuantityTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, positive, hours);
            TimeSpan timeSpan = new TimeSpan(alarmTime, 0, 0);
            Alarm expectedAlarm = new PositiveAlarm(entity, numberOfPosts, timeSpan);
            expectedAlarm.AlarmId = expectedAlarm.AlarmId - 1;
            Assert.AreEqual(expectedAlarm.RequiredPostQuantity, Data.alarmSaver.FetchAlarm(expectedAlarm).RequiredPostQuantity);
        }
        [TestMethod]
        public void AddAlarmTimeSpanQuantityTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, positive, false);
            TimeSpan timeSpan = new TimeSpan(alarmTime*24, 0, 0);
            Alarm expectedAlarm = new PositiveAlarm(entity, numberOfPosts, timeSpan);
            expectedAlarm.AlarmId = expectedAlarm.AlarmId - 1;
            Assert.AreEqual(expectedAlarm.TimeFrame, Data.alarmSaver.FetchAlarm(expectedAlarm).TimeFrame);
        }
        [TestMethod]
        public void AddAlarmTypeTest()
        {
            AlarmAdder addAlarm = new AlarmAdder(Data, entity, numberOfPosts, alarmTime, false, hours);
            TimeSpan timeSpan = new TimeSpan(alarmTime, 0, 0);
            Alarm expectedAlarm = new NegativeAlarm(entity, numberOfPosts, timeSpan);
            expectedAlarm.AlarmId = expectedAlarm.AlarmId - 1;
            Assert.AreEqual(expectedAlarm.GetType(), Data.alarmSaver.FetchAlarm(expectedAlarm).GetType());
        }
    }
}
