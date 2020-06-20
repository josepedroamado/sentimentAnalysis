using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryAlarmTest
    {
        IAlarmSaver alarmSaver;
        Entity anEntity;
        TimeSpan timeFrame;
        Alarm anAlarm;

        [TestInitialize]
        public void TestInitialize()
        {
            alarmSaver = new InMemoryAlarm();
            alarmSaver.Clear();
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
            alarmSaver.Add(anAlarm);
            alarmSaver.Add(anAlarm);
        }

        [TestMethod]
        public void DeleteExistingAlarmTest()
        {
            alarmSaver.Add(anAlarm);
            alarmSaver.Delete(anAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAlarmTest()
        {
            alarmSaver.Delete(anAlarm);
            Assert.IsNotNull(alarmSaver);
        }

        [TestMethod]
        public void FetchExistingAlarmTest()
        {
            alarmSaver.Add(anAlarm);
            Alarm fetchedAlarm = alarmSaver.Fetch(anAlarm);
            Assert.IsNotNull(fetchedAlarm);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingAlarmTest()
        {
            Assert.IsNotNull(alarmSaver.Fetch(anAlarm));
        }

        [TestMethod]
        public void ModifyExistingAlarmTest()
        {
            alarmSaver.Add(anAlarm);
            Alarm modifiedAlarm = new PositiveAlarm(anEntity, 6, timeFrame);
            alarmSaver.Modify(anAlarm, modifiedAlarm);
            Alarm fetchedAlarm = alarmSaver.Fetch(anAlarm);
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
            alarmSaver.Modify(anAlarm, modifiedAlarm);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            alarmSaver.Add(anAlarm);
            List<Alarm> expectedList = new List<Alarm>();
            expectedList.Add(anAlarm);
            List<Alarm> actualList = alarmSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
