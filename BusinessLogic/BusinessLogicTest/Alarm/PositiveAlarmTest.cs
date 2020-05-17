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

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("Entity");
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
    }
}
