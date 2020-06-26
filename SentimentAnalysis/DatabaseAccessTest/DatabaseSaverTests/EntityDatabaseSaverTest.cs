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
        IAuthorSaver authorSaver;

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
            authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
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
