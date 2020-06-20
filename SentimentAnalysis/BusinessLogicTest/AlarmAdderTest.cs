using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class AlarmAdderTest
    {
        SystemData data;
        bool hours;
        bool positive;
        int alarmTime;
        int numberOfPosts;
        Entity entity;
        AlarmAdder adder;

        [TestInitialize]
        public void TestInitialize()
        {
            IEntitySaver entitySaver = new InMemoryEntity();
            ISentimentSaver sentimentSaver = new InMemorySentiment();
            IPublicationSaver publicationSaver = new InMemoryPublication();
            IRelationSaver relationSaver = new InMemoryRelation();
            IAlarmSaver alarmSaver = new InMemoryAlarm();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
            entity = new Entity ("aText");
            numberOfPosts = 2;
            alarmTime = 3;
            positive = true;
            hours = true;
            adder = new AlarmAdder(data);
        }

        [TestMethod]
        public void NewAlarmAdderTest()
        {
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddAlarmTest()
        {
            adder.Add(entity, numberOfPosts, alarmTime, positive, hours);
            Assert.AreEqual(1, data.alarmSaver.FetchAll().Count);
        }

        [TestMethod]
        public void AddAlarmInDaysTest()
        {
            adder.Add(entity, numberOfPosts, alarmTime, positive, false);
            Assert.AreEqual(1, data.alarmSaver.FetchAll().Count);
        }

        [TestMethod]
        public void AddNegativeAlarmTest()
        {
            adder.Add(entity, numberOfPosts, alarmTime, false, hours);
            Assert.AreEqual(1, data.alarmSaver.FetchAll().Count);
        }
    }
}
