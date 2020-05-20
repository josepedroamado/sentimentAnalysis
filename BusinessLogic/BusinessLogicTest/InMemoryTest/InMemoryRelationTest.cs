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
        Entity anEntity;
        DateTime aDate;
        Publication aPublication;
        PositiveSentiment aSentiment;
        Relation aRelation;

        [TestInitialize]
        public void TestInitialize()
        {
            relationSaver = new InMemoryRelation();
            anEntity = new Entity("RelatonInMemoryTest");
            aDate = new DateTime(2020, 01, 01);
            aPublication = new Publication("RelationInMemoryPhrase", aDate);
            aSentiment = new PositiveSentiment("RelationInMemoryText");
            aRelation = new Relation(aPublication, aSentiment, anEntity);
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
            relationSaver.AddRelation(aRelation);
            relationSaver.AddRelation(aRelation);
        }

        [TestMethod]
        public void DeleteExistingRelationTest()
        {
            relationSaver.AddRelation(aRelation);
            relationSaver.DeleteRelation(aRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingRelationTest()
        {
            relationSaver.DeleteRelation(aRelation);
            Assert.IsNotNull(relationSaver);
        }

        [TestMethod]
        public void FetchExistingRelationTest()
        {
            relationSaver.AddRelation(aRelation);
            Relation fetchedRelation = relationSaver.FetchRelation(aRelation);
            Assert.IsNotNull(fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationTest()
        {
            Assert.IsNotNull(relationSaver.FetchRelation(aRelation));
        }

        [TestMethod]
        public void ModifyExistingRelationTest()
        {
            relationSaver.AddRelation(aRelation);
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate);
            Sentiment anotherSentiment = new PositiveSentiment("RelationInMemoryText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.ModifyRelation(aRelation, modifiedRelation);
            Relation fetchedRelation = relationSaver.FetchRelation(aRelation);
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
            relationSaver.ModifyRelation(aRelation, modifiedRelation);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            relationSaver.AddRelation(aRelation);
            List<Relation> expectedList = new List<Relation>();
            expectedList.Add(aRelation);
            List<Relation> actualList = relationSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}