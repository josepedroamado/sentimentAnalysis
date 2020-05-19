using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

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
            aPublication = new Publication("RelationInMemoryPhrase", aDate, 1);
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
        public void DeleteExistingRelationInMemoryRelationTest()
        {
            relationSaver.AddRelation(aRelation);
            relationSaver.DeleteRelation(aRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteRelationInMemoryRelationTest()
        {
            relationSaver.DeleteRelation(aRelation);
            Assert.IsNotNull(relationSaver);
        }

        [TestMethod]
        public void FetchExistingRelationInMemoryRelationTest()
        {
            relationSaver.AddRelation(aRelation);
            Relation fetchedRelation = relationSaver.FetchRelation(aRelation);
            Assert.IsNotNull(fetchedRelation);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingRelationInMemoryRelationTest()
        {
            Assert.IsNotNull(relationSaver.FetchRelation(aRelation));
        }

        [TestMethod]
        public void ModifyExistingRelationInMemoryRelationTest()
        {
            relationSaver.AddRelation(aRelation);
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate, 1);
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
        public void ModifyNonExistingRelationInMemoryRelationTest()
        {
            Entity anotherEntity = new Entity("RelatonInMemoryTest2");
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication anotherPublication = new Publication("RelationInMemoryPhrase2", aDate, 1);
            Sentiment anotherSentiment = new PositiveSentiment("RelationInMemoryText2");
            Relation modifiedRelation = new Relation(anotherPublication, anotherSentiment, anotherEntity);
            relationSaver.ModifyRelation(aRelation, modifiedRelation);
        }
    }
}
