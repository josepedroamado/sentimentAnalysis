using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class NegativeSentimentTest
    {
        [TestMethod]
        public void NewPositiveSentimentTitleTest()
        {
            NegativeSentiment ASentiment = new NegativeSentiment(1, "AText");
            Assert.AreEqual(ASentiment.Id, 1);
        }

        [TestMethod]
        public void NewPositiveSentimentTextTest()
        {
            NegativeSentiment ASentiment = new NegativeSentiment(1, "AText");
            Assert.AreEqual(ASentiment.Text, "AText");
        }
    }
}
