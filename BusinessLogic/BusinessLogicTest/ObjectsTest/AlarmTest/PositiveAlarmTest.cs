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
        [TestMethod]
        public void ToStringTest()
        {
            Assert.AreEqual("Entidad: PositiveAlarmEntity1, Cantidad de posts: 1 de tipo Positiva en 1 horas, Estado: Inactiva", alarm.ToString());
        }
        [TestMethod]
        public void ToStringAtiveTest()
        {
            alarm.Active = true;
            Assert.AreEqual("Entidad: PositiveAlarmEntity1, Cantidad de posts: 1 de tipo Positiva en 1 horas, Estado: Activa", alarm.ToString());
        }
    }
}
//string status = "Inactiva";
//            if(Active)
//            {
//                status = "Activa";
//            }
//            string tipo = "Positiva";
//            if(this.GetType().Name == "NegativeAlarm")
//            {
//    tipo = "Negativa";
//}

//String toReturn = String.Format("Entidad: " + this.Entity.Name + ", Cantidad de posts: " 
//                + this.RequiredPostQuantity + " de tipo " + tipo + " en " + this.TimeFrame.Hours 
//                + " horas, Estado: " + status);
//            return toReturn;