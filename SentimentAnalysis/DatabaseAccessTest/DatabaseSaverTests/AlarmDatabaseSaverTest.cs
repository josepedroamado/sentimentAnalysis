using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class AlarmDatabaseSaverTest
    {
        IAlarmSaver alarmSaver;
        IRelationSaver relationSaver;
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;
        IAuthorSaver authorSaver;
        Entity anEntity;
        Entity anotherEntity;
        TimeSpan timeFrame;
        Alarm aPositiveAlarm;
        Alarm aNegativeAlarm;

        [TestInitialize]
        public void TestInitialize()
        {
            alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
            authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            anEntity = new Entity("AlarmTest");
            anotherEntity = new Entity("AlarmTest2");
            entitySaver.Add(anEntity);
            entitySaver.Add(anotherEntity);
            timeFrame = new TimeSpan(1, 0, 0);
            aPositiveAlarm = new PositiveAlarm(anEntity, 1, timeFrame);
            aNegativeAlarm = new NegativeAlarm(anEntity, 1, timeFrame);
        }

        [TestMethod]
        public void NewAlarmTest()
        {
            Assert.IsNotNull(alarmSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewPositiveAlarmTest()
        {
            alarmSaver.Add(aPositiveAlarm);
            alarmSaver.Add(aPositiveAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewNegativeAlarmTest()
        {
            alarmSaver.Add(aNegativeAlarm);
            alarmSaver.Add(aNegativeAlarm);
        }

        [TestMethod]
        public void DeleteExistingAlarmTest()
        {
            alarmSaver.Add(aPositiveAlarm);
            alarmSaver.Delete(aPositiveAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAlarmTest()
        {
            alarmSaver.Delete(aPositiveAlarm);
        }

        [TestMethod]
        public void FetchExistingNegativeAlarmTest()
        {
            alarmSaver.Add(aNegativeAlarm);
            Alarm fetchedAlarm = alarmSaver.Fetch(aNegativeAlarm);
            Assert.IsNotNull(fetchedAlarm);
        }

        [TestMethod]
        public void FetchExistingPositiveAlarmTest()
        {
            alarmSaver.Add(aPositiveAlarm);
            Alarm fetchedAlarm = alarmSaver.Fetch(aPositiveAlarm);
            Assert.IsNotNull(fetchedAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingAlarmTest()
        {
            Assert.IsNotNull(alarmSaver.Fetch(aPositiveAlarm));
        }

        [TestMethod]
        public void ModifyExistingAlarmTest()
        {
            alarmSaver.Add(aPositiveAlarm);
            Alarm modifiedAlarm = new PositiveAlarm(anotherEntity, 6, timeFrame);
            alarmSaver.Modify(aPositiveAlarm, modifiedAlarm);
            Alarm fetchedAlarm = alarmSaver.Fetch(aPositiveAlarm);
            Assert.AreEqual(fetchedAlarm.Active, modifiedAlarm.Active);
            Assert.AreEqual(fetchedAlarm.Entity, modifiedAlarm.Entity);
            Assert.AreEqual(fetchedAlarm.RequiredPostQuantity, modifiedAlarm.RequiredPostQuantity);
            Assert.AreEqual(fetchedAlarm.TimeFrame, modifiedAlarm.TimeFrame);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingAlarmTest()
        {
            Alarm modifiedAlarm = new PositiveAlarm(anEntity, 5, timeFrame);
            alarmSaver.Modify(aPositiveAlarm, modifiedAlarm);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            alarmSaver.Add(aPositiveAlarm);
            alarmSaver.Add(aNegativeAlarm);
            Assert.AreEqual(2, alarmSaver.FetchAll().Count);
        }
    }
}
