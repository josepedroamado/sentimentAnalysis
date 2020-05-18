using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PositiveAlarmTest
    {
        Entity anEntity;
        TimeSpan aTimeFrame;
        Alarm alarm;
        Alarm secondAlarm;

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("PositiveAlarmEntity1");
            aTimeFrame = new TimeSpan(1, 0, 0);
            alarm = new PositiveAlarm(anEntity, 1, aTimeFrame);
        }
        [TestMethod]
        public void NewPositiveAlarmTest()
        { 
            Assert.IsNotNull(alarm);
        }
        [TestMethod]
        public void NewPositiveAlarmEntityTest()
        {
            Assert.AreEqual(alarm.Entity, anEntity);
        }
        [TestMethod]
        public void NewPositiveAlarmTimeFrameTest()
        {
            Assert.AreEqual(alarm.TimeFrame, aTimeFrame);
        }
        [TestMethod]
        public void NewPositiveAlarmRequiredPostQuantityTest()
        {
            Assert.AreEqual(alarm.RequiredPostQuantity, 1);
        }
        [TestMethod]
        public void NewPositiveAlarmIsActiveTest()
        {
            Assert.AreEqual(alarm.Active, false);
        }
        [TestMethod]
        public void NewPositiveAlarmNextIdTest()
        {
            int nextId = alarm.GetNextId();
            secondAlarm = new PositiveAlarm(anEntity, 2, aTimeFrame);
            Assert.AreEqual(secondAlarm.AlarmId, nextId);
        }
        [TestMethod]
        public void EqualsTruePositiveAlarmTest()
        {
            Assert.AreEqual(alarm, alarm);
        }

        [TestMethod]
        public void EqualsFalsePositiveAlarmTest()
        {
            secondAlarm = new PositiveAlarm(anEntity, 2, aTimeFrame);
            Assert.AreNotEqual(alarm, secondAlarm);
        }

        [TestMethod]
        public void EqualsNullPositiveAlarmTest()
        {
            Assert.IsFalse(alarm.Equals(null));
        }

        [TestMethod]
        public void AlarmUnequalHashCodeTest()
        {
            secondAlarm = new PositiveAlarm(anEntity, 1, aTimeFrame);
            Assert.AreNotEqual(alarm.GetHashCode(), secondAlarm.GetHashCode());
        }

        [TestMethod]
        public void AlarmEqualHashCodeTest()
        {
            secondAlarm = new PositiveAlarm(anEntity, 1, aTimeFrame);
            secondAlarm.AlarmId = alarm.AlarmId;
            Assert.AreEqual(alarm.GetHashCode(), secondAlarm.GetHashCode());
        }
    }
}
