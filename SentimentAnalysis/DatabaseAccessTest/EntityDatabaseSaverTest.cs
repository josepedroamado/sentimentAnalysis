using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class EntityDatabaseSaverTest
    {
        Entity anEntity;
        IAlarmSaver alarmSaver;
        IRelationSaver relationSaver;
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;

        [TestInitialize]
        public void TestInitialize()
        {
            anEntity = new Entity("InMemoryEntityTest1");

            alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
        }

        [TestMethod]
        public void CreateEntityDatabaseSaverTest()
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
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void EntityAlreadyExistsWithThatNameTest()
        {
            entitySaver.AddEntity(anEntity);
            Entity entity = new Entity("InMemoryEntityTest1");
            entitySaver.AddEntity(entity);
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
        public void FetchExistingEntityByObjectTest()
        {
            entitySaver.AddEntity(anEntity);
            Entity fetchedEntity = entitySaver.FetchEntity(anEntity);
            Assert.IsNotNull(fetchedEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingEntityByObjectTest()
        {
            Assert.IsNotNull(entitySaver.FetchEntity(anEntity));
        }

        [TestMethod]
        public void FetchExistingEntityByIdTest()
        {
            entitySaver.AddEntity(anEntity);
            Entity fetchedEntity = entitySaver.FetchEntity(anEntity.EntityId);
            Assert.IsNotNull(fetchedEntity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingEntityByIdTest()
        {
            Assert.IsNotNull(entitySaver.FetchEntity(anEntity.EntityId));
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

        [TestMethod]
        public void FetchAllTest()
        {
            entitySaver.AddEntity(anEntity);
            List<Entity> expectedList = new List<Entity>();
            expectedList.Add(anEntity);
            List<Entity> actualList = entitySaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
