using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryRelationTest
    {
        IRelationSaver relationSaver;
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
        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);

            relationSaver = new InMemoryRelation();
            firstEntity = new Entity("RelatonInMemoryTest");
            secondEntity = new Entity("Entity2");
            aDate = new DateTime(2020, 01, 01);
            firstPublication = new Publication("RelationInMemoryPhrase", aDate, anAuthor);
            secondPublication = new Publication("Second Publication", aDate, anAuthor);
            thirdPublication = new Publication("Third Publication", aDate, anAuthor);
            aSentiment = new PositiveSentiment("RelationInMemoryText");
            firstRelation = new Relation(firstPublication, aSentiment, firstEntity);
            secondRelation = new Relation(secondPublication, aSentiment, secondEntity);
            thirdRelation = new Relation(thirdPublication, aSentiment, firstEntity);
        }

        [TestMethod]
        public void NewInMemoryRelationTest()
        {
            Assert.IsNotNull(relationSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewInMemoryRelationTest()
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
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate, anAuthor);
            Sentiment anotherSentiment = new PositiveSentiment("RelationInMemoryText2");
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
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate, anAuthor);
            Sentiment anotherSentiment = new PositiveSentiment("RelationInMemoryText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.ModifyRelation(firstRelation, modifiedRelation);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            relationSaver.AddRelation(firstRelation);
            List<Relation> expectedList = new List<Relation>();
            expectedList.Add(firstRelation);
            List<Relation> actualList = relationSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }

        [TestMethod]
        public void FetchAllPublicationsOfFirstEntityTest()
        {
            relationSaver.AddRelation(firstRelation);
            relationSaver.AddRelation(secondRelation);
            relationSaver.AddRelation(thirdRelation);
            List<Publication> expectedList = new List<Publication>();
            expectedList.Add(firstPublication);
            expectedList.Add(thirdPublication);
            List<Publication> actualList = relationSaver.FetchAllPublicationsOfEntity(firstEntity.EntityId);
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
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
