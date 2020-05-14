using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class RelationTest
    {
        [TestMethod]
        public void NewRelationTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("Phrase", aDate, 1);
            Sentiment aSentiment = new PositiveSentiment(1, "Positive");
            Entity anEntity = new Entity("Entity");
            Relation aRelation = new Relation(aPublication, aSentiment, anEntity);
            Assert.IsNotNull(aRelation);
        }

        [TestMethod]
        public void NewRelationPublicationTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("Phrase", aDate, 1);
            Sentiment aSentiment = new PositiveSentiment(1, "Positive");
            Entity anEntity = new Entity("Entity");
            Relation aRelation = new Relation(aPublication, aSentiment, anEntity);
            Assert.AreEqual(aRelation.Publication, aPublication);
        }

        [TestMethod]
        public void NewRelationSentimentTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("Phrase", aDate, 1);
            Sentiment aSentiment = new PositiveSentiment(1, "Positive");
            Entity anEntity = new Entity("Entity");
            Relation aRelation = new Relation(aPublication, aSentiment, anEntity);
            Assert.AreEqual(aRelation.Sentiment, aSentiment);
        }

        [TestMethod]
        public void NewRelationEntityTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("Phrase", aDate, 1);
            Sentiment aSentiment = new PositiveSentiment(1, "Positive");
            Entity anEntity = new Entity("Entity");
            Relation aRelation = new Relation(aPublication, aSentiment, anEntity);
            Assert.AreEqual(aRelation.Entity, anEntity);
        }
    }
}
