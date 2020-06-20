﻿using System;
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

        [TestInitialize]
        public void TestInitialize()
        {
            relationSaver = new InMemoryRelation();
            relationSaver.Clear();
            firstEntity = new Entity("RelatonInMemoryTest");
            secondEntity = new Entity("Entity2");
            aDate = new DateTime(2020, 01, 01);
            firstPublication = new Publication("RelationInMemoryPhrase", aDate);
            secondPublication = new Publication("Second Publication", aDate);
            thirdPublication = new Publication("Third Publication", aDate);
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
            Relation fetchedRelation = relationSaver.Fetch(firstPublication.PublicationId);
            Assert.AreEqual(firstRelation, fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationByPublicationIdTest()
        {
            Assert.IsNotNull(relationSaver.Fetch(firstRelation.Publication.PublicationId));
        }

        [TestMethod]
        public void ModifyExistingRelationTest()
        {
            relationSaver.Add(firstRelation);
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate);
            Sentiment anotherSentiment = new PositiveSentiment("RelationInMemoryText2");
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
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate);
            Sentiment anotherSentiment = new PositiveSentiment("RelationInMemoryText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.Modify(firstRelation, modifiedRelation);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            relationSaver.Add(firstRelation);
            List<Relation> expectedList = new List<Relation>();
            expectedList.Add(firstRelation);
            List<Relation> actualList = relationSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }

        [TestMethod]
        public void FetchAllPublicationsOfFirstEntityTest()
        {
            relationSaver.Add(firstRelation);
            relationSaver.Add(secondRelation);
            relationSaver.Add(thirdRelation);
            List<Publication> expectedList = new List<Publication>();
            expectedList.Add(firstPublication);
            expectedList.Add(thirdPublication);
            List<Publication> actualList = relationSaver.FetchAllPublicationsOfEntity(firstEntity.EntityId);
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
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
