using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class NegativeAlarmTest
    {
        Entity anEntity;
        TimeSpan aTimeFrame;
        Alarm alarm;
        Alarm secondAlarm;

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("NegativeAlarmEntity1");
            aTimeFrame = new TimeSpan(1, 0, 0);
            alarm = new NegativeAlarm(anEntity, 1, aTimeFrame);
        }

        [TestMethod]
        public void NewNegativeAlarmTest()
        {
            Assert.IsNotNull(alarm);
        }

        [TestMethod]
        public void NewNegativeAlarmEntityTest()
        {
            Assert.AreEqual(alarm.Entity, anEntity);
        }

        [TestMethod]
        public void NewNegativeAlarmTimeFrameTest()
        {
            Assert.AreEqual(alarm.TimeFrame, aTimeFrame.Ticks);
        }

        [TestMethod]
        public void NewNegativeAlarmRequiredPostQuantityTest()
        {
            Assert.AreEqual(alarm.RequiredPostQuantity, 1);
        }

        [TestMethod]
        public void NewNegativeAlarmIsActiveTest()
        {
            Assert.AreEqual(alarm.Active, false);
        }

        [TestMethod]
        public void EqualsTrueNegativeAlarmTest()
        {
            Assert.AreEqual(alarm, alarm);
        }

        [TestMethod]
        public void EqualsFalseNegativeAlarmTest()
        {
            secondAlarm = new NegativeAlarm(anEntity, 2, aTimeFrame);
            Assert.AreNotEqual(alarm, secondAlarm);
        }

        [TestMethod]
        public void EqualsNullNegativeAlarmTest()
        {
            Assert.IsFalse(alarm.Equals(null));
        }

        [TestMethod]
        public void AlarmUnequalHashCodeTest()
        {
            secondAlarm = new NegativeAlarm(anEntity, 1, aTimeFrame);
            Assert.AreNotEqual(alarm.GetHashCode(), secondAlarm.GetHashCode());
        }

        [TestMethod]
        public void AlarmEqualHashCodeTest()
        {
            secondAlarm = new NegativeAlarm(anEntity, 1, aTimeFrame);
            secondAlarm.AlarmId = alarm.AlarmId;
            Assert.AreEqual(alarm.GetHashCode(), secondAlarm.GetHashCode());
        }
        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Entidad: NegativeAlarmEntity1, Cantidad de posts: 1 de tipo Negativa en 1 horas, Estado: Inactiva", alarm.ToString());
        }
    }
}
