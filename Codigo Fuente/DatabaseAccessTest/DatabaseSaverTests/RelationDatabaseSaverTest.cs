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
        IAuthorSaver authorSaver;
        Entity firstEntity;
        Entity secondEntity;
        Author firstAuthor;
        Author secondAuthor;
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
            authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();

            aSentiment = new PositiveSentiment("RelationText");
            sentimentSaver.Add(aSentiment);

            firstEntity = new Entity("RelatonTest");
            secondEntity = new Entity("Entity2");
            entitySaver.Add(firstEntity);
            entitySaver.Add(secondEntity);

            firstAuthor = new Author("author1", "FirstName1", "LastName1", new DateTime(1965, 5, 5));
            secondAuthor = new Author("author2", "FirstName2", "LastName2", new DateTime(1985, 5, 5));
            authorSaver.Add(firstAuthor);
            authorSaver.Add(secondAuthor);

            firstPublication = new Publication("First Publication", new DateTime(2020, 01, 01), firstAuthor);
            secondPublication = new Publication("Second Publication", new DateTime(2020, 02, 01), secondAuthor);
            thirdPublication = new Publication("Third Publication", new DateTime(2020, 03, 01), firstAuthor);
            publicationSaver.Add(firstPublication);
            publicationSaver.Add(secondPublication);
            publicationSaver.Add(thirdPublication);

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
            relationSaver.Add(firstRelation);
            relationSaver.Add(firstRelation);
        }

        [TestMethod]
        public void DeleteExistingRelationTest()
        {
            relationSaver.Add(firstRelation);
            relationSaver.Delete(firstRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingRelationTest()
        {
            relationSaver.Delete(firstRelation);
            Assert.IsNotNull(relationSaver);
        }

        [TestMethod]
        public void FetchExistingRelationTest()
        {
            relationSaver.Add(firstRelation);
            Relation fetchedRelation = relationSaver.Fetch(firstRelation);
            Assert.IsNotNull(fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationTest()
        {
            Assert.IsNotNull(relationSaver.Fetch(firstRelation));
        }

        [TestMethod]
        public void FetchExistingRelationByPublicationIdTest()
        {
            relationSaver.Add(firstRelation);
            Relation fetchedRelation = relationSaver.FetchWithPublication(firstPublication.PublicationId);
            Assert.AreEqual(firstRelation, fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationByPublicationIdTest()
        {
            Assert.IsNotNull(relationSaver.FetchWithPublication(firstRelation.Publication.PublicationId));
        }

        [TestMethod]
        public void ModifyExistingRelationTest()
        {
            relationSaver.Add(firstRelation);
            Entity anotherEntity = new Entity("RelationTest2");
            entitySaver.Add(anotherEntity);
            Publication anotherPublication = new Publication("RelationPhrase2", new DateTime(2022, 01, 01), secondAuthor);
            publicationSaver.Add(anotherPublication);
            Sentiment anotherSentiment = new PositiveSentiment("RelationText2");
            sentimentSaver.Add(anotherSentiment);
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.Modify(firstRelation, modifiedRelation);
            Relation fetchedRelation = relationSaver.Fetch(firstRelation);
            Assert.AreEqual(fetchedRelation.Publication, modifiedRelation.Publication);
            Assert.AreEqual(fetchedRelation.Sentiment, modifiedRelation.Sentiment);
            Assert.AreEqual(fetchedRelation.Entity, modifiedRelation.Entity);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingRelationTest()
        {
            Entity anotherEntity = new Entity("RelationTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationPhrase2", new DateTime(2020, 04, 01), secondAuthor);
            Sentiment anotherSentiment = new PositiveSentiment("RelationText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.Modify(firstRelation, modifiedRelation);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            relationSaver.Add(firstRelation);
            Assert.AreEqual(1, relationSaver.FetchAll().Count());
        }

        [TestMethod]
        public void FetchAllPublicationsOfFirstEntityTest()
        {
            relationSaver.Add(firstRelation);
            relationSaver.Add(secondRelation);
            relationSaver.Add(thirdRelation);
            Relation fetched = relationSaver.Fetch(firstRelation);
            Assert.AreEqual(2, relationSaver.FetchAllPublicationsOfEntity(fetched.Entity.EntityId).Count());
        }

        [TestMethod]
        public void FetchAllPublicationsOfSecondEntityTest()
        {
            relationSaver.Add(firstRelation);
            relationSaver.Add(secondRelation);
            relationSaver.Add(thirdRelation);
            List<Publication> expectedList = new List<Publication>();
            expectedList.Add(secondPublication);
            List<Publication> actualList = relationSaver.FetchAllPublicationsOfEntity(secondEntity.EntityId);
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
