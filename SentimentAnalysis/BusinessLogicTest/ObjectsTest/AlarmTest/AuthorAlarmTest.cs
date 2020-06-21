using System;
using BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorAlarmTest
    {
        Entity anEntity;
        TimeSpan aTimeFrame;
        Alarm alarm;
        Alarm secondAlarm;

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("AuthorAlarmEntity1");
            aTimeFrame = new TimeSpan(1, 0, 0);
            alarm = new AuthorAlarm(anEntity, 1, aTimeFrame, "Positivas");
        }

        [TestMethod]
        public void NewAuthorAlarmTest()
        {
            Assert.IsNotNull(alarm);
        }

        [TestMethod]
        public void NewEntityTest()
        {
            Assert.AreEqual(alarm.Entity, anEntity);
        }

        [TestMethod]
        public void NewTimeFrameTest()
        {
            Assert.AreEqual(alarm.TimeFrame, aTimeFrame.Ticks);
        }

        [TestMethod]
        public void NewRequiredPostQuantityTest()
        {
            Assert.AreEqual(alarm.RequiredPostQuantity, 1);
        }

        [TestMethod]
        public void NewIsActiveTest()
        {
            Assert.AreEqual(alarm.Active, false);
        }

        [TestMethod]
        public void EqualsTrueTest()
        {
            Assert.AreEqual(alarm, alarm);
        }

        [TestMethod]
        public void EqualsFalseTest()
        {
            secondAlarm = new AuthorAlarm(anEntity, 2, aTimeFrame, "Negativas");
            Assert.AreNotEqual(alarm, secondAlarm);
        }

        [TestMethod]
        public void EqualsNullTest()
        {
            Assert.IsFalse(alarm.Equals(null));
        }

        [TestMethod]
        public void AlarmUnequalHashCodeTest()
        {
            secondAlarm = new AuthorAlarm(anEntity, 1, aTimeFrame, "Negativas");
            Assert.AreNotEqual(alarm.GetHashCode(), secondAlarm.GetHashCode());
        }

        [TestMethod]
        public void AlarmEqualHashCodeTest()
        {
            secondAlarm = new AuthorAlarm(anEntity, 1, aTimeFrame, "Negativas");
            secondAlarm.AlarmId = alarm.AlarmId;
            Assert.AreEqual(alarm.GetHashCode(), secondAlarm.GetHashCode());
        }
    }
}
