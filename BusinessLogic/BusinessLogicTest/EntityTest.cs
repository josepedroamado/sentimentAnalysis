using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityTest
    {
        [TestMethod]
        public void NewEntityTest()
        {
            Entity aEntity = new Entity("AName");
            Assert.IsNotNull(aEntity);
        }
        [TestMethod]
        public void AddSentimentEntityTest()
        {
            Entity aEntity = new Entity("AName");
            Sentiment aSentiment = new PositiveSentiment(1, "Good");
            aEntity.AddSentiment(aSentiment);
            Assert.AreEqual(aSentiment, aEntity.GetSentiments()[0]);
        }
    }
}
