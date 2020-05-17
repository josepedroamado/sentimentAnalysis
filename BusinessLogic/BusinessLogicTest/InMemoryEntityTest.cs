using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryEntityTest
    {
        [TestMethod]
        public void CreateInMemoryEntityTest()
        {
            IEntitySaver aEntitySaver = new InMemoryEntity();
            Assert.IsNotNull(aEntitySaver);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void EntityExistsTest()
        {
            IEntitySaver aEntitySaver = new InMemoryEntity();
            Entity aEntity = new Entity("aText");
            aEntitySaver.AddEntity(aEntity);
            aEntitySaver.AddEntity(aEntity);
            Assert.IsNotNull(aEntitySaver);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void EntityDeleteNotExistsTest()
        {
            IEntitySaver aEntitySaver = new InMemoryEntity();
            aEntitySaver.DeleteEntity("aText");            
        }
        [TestMethod]
        public void EntityFetchTest()
        {
            IEntitySaver aEntitySaver = new InMemoryEntity();
            Entity aEntity = new Entity("aText");
            aEntitySaver.AddEntity(aEntity);
            Entity recieved = aEntitySaver.FetchEntity("aText");
            Assert.AreEqual(aEntity, recieved);            
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void EntityFetchNoEntityTest()
        {
            IEntitySaver aEntitySaver = new InMemoryEntity();
            Entity aEntity = new Entity("aText");
            Entity recieved = aEntitySaver.FetchEntity("aText");
            Assert.AreEqual(aEntity, recieved);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void EntityDeleteTest()
        {
            IEntitySaver aEntitySaver = new InMemoryEntity();
            Entity aEntity = new Entity("aText");
            aEntitySaver.AddEntity(aEntity);
            aEntitySaver.DeleteEntity("aText");
            Entity recieved = aEntitySaver.FetchEntity("aText");
            Assert.AreEqual(aEntity, recieved);
        }
    }
}
