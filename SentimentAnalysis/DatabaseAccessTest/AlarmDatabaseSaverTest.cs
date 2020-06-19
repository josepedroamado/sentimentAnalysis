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
            anEntity = new Entity("AlarmTest");
            anotherEntity = new Entity("AlarmTest2");
            entitySaver.AddEntity(anEntity);
            entitySaver.AddEntity(anotherEntity);
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
            alarmSaver.AddAlarm(aPositiveAlarm);
            alarmSaver.AddAlarm(aPositiveAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewNegativeAlarmTest()
        {
            alarmSaver.AddAlarm(aNegativeAlarm);
            alarmSaver.AddAlarm(aNegativeAlarm);
        }

        [TestMethod]
        public void DeleteExistingAlarmTest()
        {
            alarmSaver.AddAlarm(aPositiveAlarm);
            alarmSaver.DeleteAlarm(aPositiveAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAlarmTest()
        {
            alarmSaver.DeleteAlarm(aPositiveAlarm);
            Assert.IsNotNull(alarmSaver);
        }

        [TestMethod]
        public void FetchExistingNegativeAlarmTest()
        {
            alarmSaver.AddAlarm(aNegativeAlarm);
            Alarm fetchedAlarm = alarmSaver.FetchAlarm(aNegativeAlarm);
            Assert.IsNotNull(fetchedAlarm);
        }

        [TestMethod]
        public void FetchExistingPositiveAlarmTest()
        {
            alarmSaver.AddAlarm(aPositiveAlarm);
            Alarm fetchedAlarm = alarmSaver.FetchAlarm(aPositiveAlarm);
            Assert.IsNotNull(fetchedAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingAlarmTest()
        {
            Assert.IsNotNull(alarmSaver.FetchAlarm(aPositiveAlarm));
        }

        [TestMethod]
        public void ModifyExistingAlarmTest()
        {
            alarmSaver.AddAlarm(aPositiveAlarm);
            Alarm modifiedAlarm = new PositiveAlarm(anotherEntity, 6, timeFrame);
            alarmSaver.ModifyAlarm(aPositiveAlarm, modifiedAlarm);
            Alarm fetchedAlarm = alarmSaver.FetchAlarm(aPositiveAlarm);
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
            alarmSaver.ModifyAlarm(aPositiveAlarm, modifiedAlarm);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            alarmSaver.AddAlarm(aPositiveAlarm);
            alarmSaver.AddAlarm(aNegativeAlarm);
            Assert.AreEqual(2, alarmSaver.FetchAll().Count);
        }
    }
}
