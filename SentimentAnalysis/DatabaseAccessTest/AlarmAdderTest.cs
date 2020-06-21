using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
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
            IAuthorSaver authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            IAlarmSaver alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            IRelationSaver relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            IPublicationSaver publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            IEntitySaver entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            ISentimentSaver sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);
            entity = new Entity("aText");
            data.entitySaver.Add(entity);
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
        public void AddAlarmEntityTest()
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
