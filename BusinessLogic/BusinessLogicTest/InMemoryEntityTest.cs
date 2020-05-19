using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

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
            entitySaver.AddEntity(anEntity);
            entitySaver.AddEntity(anEntity);
        }

        [TestMethod]
        public void DeleteExistingEntityTest()
        {
            entitySaver.AddEntity(anEntity);
            entitySaver.DeleteEntity(anEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingEntityTest()
        {
            entitySaver.DeleteEntity(anEntity);
            Assert.IsNotNull(entitySaver);
        }

        [TestMethod]
        public void FetchExistingEntityTest()
        {
            entitySaver.AddEntity(anEntity);
            Entity fetchedEntity = entitySaver.FetchEntity(anEntity);
            Assert.IsNotNull(fetchedEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingEntityTest()
        {
            Assert.IsNotNull(entitySaver.FetchEntity(anEntity));
        }

        [TestMethod]
        public void ModifyExistingEntityTest()
        {
            entitySaver.AddEntity(anEntity);
            Entity modifiedEntity = new Entity("InMemoryEntityTest2");
            entitySaver.ModifyEntity(anEntity, modifiedEntity);
            Entity fetchedEntity = entitySaver.FetchEntity(anEntity);
            Assert.AreEqual(fetchedEntity.Name, modifiedEntity.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingEntityTest()
        {
            Entity modifiedEntity = new Entity("InMemoryEntityTest3");
            entitySaver.ModifyEntity(anEntity, modifiedEntity);
        }
    }
}
