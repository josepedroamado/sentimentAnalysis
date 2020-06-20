using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryEntityTest
    {
        IEntitySaver entitySaver;
        Entity anEntity;

        [TestInitialize]
        public void TestInitialize()
        {
            entitySaver = new InMemoryEntity();
            entitySaver.Clear();
            anEntity = new Entity("InMemoryEntityTest1");
        }

        [TestMethod]
        public void CreateInMemoryEntityTest()
        {
            Assert.IsNotNull(entitySaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void EntityExistsTest()
        {
            entitySaver.Add(anEntity);
            entitySaver.Add(anEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void EntityAlreadyExistsWithThatNameTest()
        {
            entitySaver.Add(anEntity);
            Entity entity = new Entity("InMemoryEntityTest1");
            entitySaver.Add(entity);
        }

        [TestMethod]
        public void DeleteExistingEntityTest()
        {
            entitySaver.Add(anEntity);
            entitySaver.Delete(anEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingEntityTest()
        {
            entitySaver.Delete(anEntity);
            Assert.IsNotNull(entitySaver);
        }

        [TestMethod]
        public void FetchExistingEntityByObjectTest()
        {
            entitySaver.Add(anEntity);
            Entity fetchedEntity = entitySaver.Fetch(anEntity);
            Assert.IsNotNull(fetchedEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingEntityByObjectTest()
        {
            Assert.IsNotNull(entitySaver.Fetch(anEntity));
        }

        [TestMethod]
        public void FetchExistingEntityByIdTest()
        {
            entitySaver.Add(anEntity);
            Entity fetchedEntity = entitySaver.Fetch(anEntity.EntityId);
            Assert.IsNotNull(fetchedEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingEntityByIdTest()
        {
            Assert.IsNotNull(entitySaver.Fetch(anEntity.EntityId));
        }

        [TestMethod]
        public void ModifyExistingEntityTest()
        {
            entitySaver.Add(anEntity);
            Entity modifiedEntity = new Entity("InMemoryEntityTest2");
            entitySaver.Modify(anEntity, modifiedEntity);
            Entity fetchedEntity = entitySaver.Fetch(anEntity);
            Assert.AreEqual(fetchedEntity.Name, modifiedEntity.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingEntityTest()
        {
            Entity modifiedEntity = new Entity("InMemoryEntityTest3");
            entitySaver.Modify(anEntity, modifiedEntity);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            entitySaver.Add(anEntity);
            List<Entity> expectedList = new List<Entity>();
            expectedList.Add(anEntity);
            List<Entity> actualList = entitySaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
