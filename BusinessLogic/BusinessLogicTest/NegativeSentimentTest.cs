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
            NegativeSentiment ASentiment = new NegativeSentiment("aTitle", "AText");
            Assert.AreEqual(ASentiment.Title, "aTitle");
        }

        [TestMethod]
        public void NewPositiveSentimentTextTest()
        {
            NegativeSentiment ASentiment = new NegativeSentiment("aTitle", "AText");
            Assert.AreEqual(ASentiment.Text, "AText");
        }
    }
}
