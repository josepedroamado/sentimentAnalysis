﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryAlarmTest
    {
        IAlarmSaver alarmSaver;
        Entity anEntity = new Entity("AlarmInMemoryTest");
        TimeSpan timeFrame;
        Alarm anAlarm;

        [TestInitialize]
        public void TestInitialize()
        {
            alarmSaver = new InMemoryAlarm();
            anEntity = new Entity("AlarmInMemoryTest");
            timeFrame = new TimeSpan(1, 0, 0);
            anAlarm = new PositiveAlarm(anEntity, 1, timeFrame);
        }

        [TestMethod]
        public void NewInMemoryAlarmTest()
        {
            Assert.IsNotNull(alarmSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewInMemoryAlarmTest()
        {
            alarmSaver.AddAlarm(anAlarm);
            alarmSaver.AddAlarm(anAlarm);
        }

        [TestMethod]
        public void DeleteExistingAlarmTest()
        {
            alarmSaver.AddAlarm(anAlarm);
            alarmSaver.DeleteAlarm(anAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAlarmTest()
        {
            alarmSaver.DeleteAlarm(anAlarm);
            Assert.IsNotNull(alarmSaver);
        }

        [TestMethod]
        public void FetchExistingAlarmTest()
        {
            alarmSaver.AddAlarm(anAlarm);
            Alarm fetchedAlarm = alarmSaver.FetchAlarm(anAlarm);
            Assert.IsNotNull(fetchedAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingAlarmTest()
        {
            Assert.IsNotNull(alarmSaver.FetchAlarm(anAlarm));
        }

        [TestMethod]
        public void ModifyExistingAlarmTest()
        {
            alarmSaver.AddAlarm(anAlarm);
            Alarm modifiedAlarm = new PositiveAlarm(anEntity, 6, timeFrame);
            alarmSaver.ModifyAlarm(anAlarm, modifiedAlarm);
            Alarm fetchedAlarm = alarmSaver.FetchAlarm(anAlarm);
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
            alarmSaver.ModifyAlarm(anAlarm, modifiedAlarm);
        }
    }
}