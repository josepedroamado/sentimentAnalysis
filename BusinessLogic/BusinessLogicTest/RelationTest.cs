using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class RelationTest
    {
        DateTime aDate;
        Publication aPublication;
        Sentiment aSentiment;
        Entity anEntity;
        Relation aRelation;

        [TestInitialize]
        public void TestInitialize()
        {
            aDate = new DateTime(2020, 01, 01);
            aPublication = new Publication("Phrase", aDate, 1);
            aSentiment = new PositiveSentiment("Positive");
            anEntity = new Entity("Entity");
            aRelation = new Relation(aPublication, aSentiment, anEntity);
        }

        [TestMethod]
        public void NewRelationTest()
        {
            Assert.IsNotNull(aRelation);
        }

        [TestMethod]
        public void NewRelationPublicationTest()
        {     
            Assert.AreEqual(aRelation.Publication, aPublication);
        }

        [TestMethod]
        public void NewRelationSentimentTest()
        {
            Assert.AreEqual(aRelation.Sentiment, aSentiment);
        }

        [TestMethod]
        public void NewRelationEntityTest()
        {
            Assert.AreEqual(aRelation.Entity, anEntity);
        }
    }
}
