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

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("Entity");
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
            Assert.AreEqual(alarm.TimeFrame, aTimeFrame);
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
    }
}
