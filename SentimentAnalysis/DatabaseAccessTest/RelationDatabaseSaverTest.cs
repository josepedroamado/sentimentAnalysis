using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class RelationDatabaseSaverTest
    {
        IAlarmSaver alarmSaver;
        IRelationSaver relationSaver;
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;
        Entity firstEntity;
        Entity secondEntity;
        DateTime aDate;
        Publication firstPublication;
        Publication secondPublication;
        Publication thirdPublication;
        PositiveSentiment aSentiment;
        Relation firstRelation;
        Relation secondRelation;
        Relation thirdRelation;

        [TestInitialize]
        public void TestInitialize()
        {
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

            aSentiment = new PositiveSentiment("RelationText");
            sentimentSaver.AddSentiment(aSentiment);

            firstEntity = new Entity("RelatonTest");
            entitySaver.AddEntity(firstEntity);
            secondEntity = new Entity("Entity2");
            entitySaver.AddEntity(secondEntity);

            aDate = new DateTime(2020, 01, 01);
            firstPublication = new Publication("RelationPhrase", aDate);
            publicationSaver.AddPublication(firstPublication);
            secondPublication = new Publication("Second Publication", aDate);
            publicationSaver.AddPublication(secondPublication);
            thirdPublication = new Publication("Third Publication", aDate);
            publicationSaver.AddPublication(thirdPublication);

            firstRelation = new Relation(firstPublication, aSentiment, firstEntity);
            secondRelation = new Relation(secondPublication, aSentiment, secondEntity);
            thirdRelation = new Relation(thirdPublication, aSentiment, firstEntity);        
        }

        [TestMethod]
        public void NewRelationDatabaseSaverTest()
        {
            Assert.IsNotNull(relationSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddExistingRelationTest()
        {
            relationSaver.AddRelation(firstRelation);
            relationSaver.AddRelation(firstRelation);
        }

        [TestMethod]
        public void DeleteExistingRelationTest()
        {
            relationSaver.AddRelation(firstRelation);
            relationSaver.DeleteRelation(firstRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingRelationTest()
        {
            relationSaver.DeleteRelation(firstRelation);
            Assert.IsNotNull(relationSaver);
        }

        [TestMethod]
        public void FetchExistingRelationTest()
        {
            relationSaver.AddRelation(firstRelation);
            Relation fetchedRelation = relationSaver.FetchRelation(firstRelation);
            Assert.IsNotNull(fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationTest()
        {
            Assert.IsNotNull(relationSaver.FetchRelation(firstRelation));
        }

        [TestMethod]
        public void FetchExistingRelationByPublicationIdTest()
        {
            relationSaver.AddRelation(firstRelation);
            Relation fetchedRelation = relationSaver.FetchRelation(firstPublication.PublicationId);
            Assert.AreEqual(firstRelation, fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationByPublicationIdTest()
        {
            Assert.IsNotNull(relationSaver.FetchRelation(firstRelation.Publication.PublicationId));
        }

        [TestMethod]
        public void ModifyExistingRelationTest()
        {
            relationSaver.AddRelation(firstRelation);
            Entity anotherEntity = new Entity("RelatonTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationPhrase2", aDate);
            Sentiment anotherSentiment = new PositiveSentiment("RelationText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.ModifyRelation(firstRelation, modifiedRelation);
            Relation fetchedRelation = relationSaver.FetchRelation(firstRelation);
            Assert.AreEqual(fetchedRelation.Publication, modifiedRelation.Publication);
            Assert.AreEqual(fetchedRelation.Sentiment, modifiedRelation.Sentiment);
            Assert.AreEqual(fetchedRelation.Entity, modifiedRelation.Entity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingRelationTest()
        {
            Entity anotherEntity = new Entity("RelatonTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationPhrase2", aDate);
            Sentiment anotherSentiment = new PositiveSentiment("RelationText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.ModifyRelation(firstRelation, modifiedRelation);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            relationSaver.AddRelation(firstRelation);
            Assert.AreEqual(1, relationSaver.FetchAll().Count());
        }

        [TestMethod]
        public void FetchAllPublicationsOfFirstEntityTest()
        {
            relationSaver.AddRelation(firstRelation);
            relationSaver.AddRelation(secondRelation);
            relationSaver.AddRelation(thirdRelation);
            Relation fetched = relationSaver.FetchRelation(firstRelation);
            Assert.AreEqual(2, relationSaver.FetchAllPublicationsOfEntity(fetched.Entity.EntityId).Count());
        }

        [TestMethod]
        public void FetchAllPublicationsOfSecondEntityTest()
        {
            relationSaver.AddRelation(firstRelation);
            relationSaver.AddRelation(secondRelation);
            relationSaver.AddRelation(thirdRelation);
            List<Publication> expectedList = new List<Publication>();
            expectedList.Add(secondPublication);
            List<Publication> actualList = relationSaver.FetchAllPublicationsOfEntity(secondEntity.EntityId);
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
