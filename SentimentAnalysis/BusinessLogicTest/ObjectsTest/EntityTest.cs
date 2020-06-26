using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityTest
    {
        Entity anEntity;
        Entity anotherEntity;

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("AName");
        }

        [TestMethod]
        public void NewEntityTest()
        {
            Assert.IsNotNull(anEntity);
        }

        [TestMethod]
        public void NewEntityNameTest()
        {
            Assert.AreEqual(anEntity.Name, "AName");
        }

        [TestMethod]
        public void EqualsTrueEntityTest()
        {
            Assert.AreEqual(anEntity, anEntity);
        }

        [TestMethod]
        public void EqualsFalseEntityTest()
        {
            anotherEntity = new Entity("AnotherName2");
            Assert.AreNotEqual(anEntity, anotherEntity);
        }

        [TestMethod]
        public void EqualsNullEntityTest()
        {
            Assert.IsFalse(anEntity.Equals(null));
        }

        [TestMethod]
        public void EntityUnequalHashCodeTest()
        {
            anotherEntity = new Entity("AnotherName3");
            Assert.AreNotEqual(anEntity.GetHashCode(), anotherEntity.GetHashCode());
        }

        [TestMethod]
        public void EntityEqualHashCodeTest()
        {
            anotherEntity = new Entity("AnotherName4");
            anotherEntity.EntityId = anEntity.EntityId;
            Assert.AreEqual(anEntity.GetHashCode(), anotherEntity.GetHashCode());
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooLongException))]
        public void EntityTextToLongTest()
        {
            String name = "";
            while (name.Length < 100)
            {
                name = name + "assdda";
            }
            Entity aEntity = new Entity(name);
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void EntityTextToShortTest()
        {
            String name = "";
            Entity aEntity = new Entity(name);
        }
    }
}
