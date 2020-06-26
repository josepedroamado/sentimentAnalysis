using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class NegativeSentimentTest
    {
        NegativeSentiment aSentiment;
        Sentiment anotherSentiment;

        [TestInitialize]
        public void TestInitialize()
        {
            aSentiment = new NegativeSentiment("AText");
        }

        [TestMethod]
        public void NewNegativeSentimentTest()
        {
            Assert.IsNotNull(aSentiment);
        }

        [TestMethod]
        public void NewNegativeSentimentTextTest()
        {
            Assert.AreEqual(aSentiment.Text, "AText");
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooLongException))]
        public void NegativeSentimentTextBiggerThanMaxTest()
        {
            String AText = "1";
            while (AText.Length <= 100)
            {
                AText = AText + "more characters";
            }
            NegativeSentiment ASentiment = new NegativeSentiment(AText);
        }
        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void NegativeSentimentTextShorterThanMaxTest()
        {
            String AText = "1";
            NegativeSentiment ASentiment = new NegativeSentiment(AText);
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void NegativeSentimentTextEmptyTest()
        {
            String AText = " ";
            NegativeSentiment ASentiment = new NegativeSentiment(AText);
        }

        [TestMethod]
        public void EqualsTrueNegativeSentimentTest()
        {
            Assert.AreEqual(aSentiment, aSentiment);
        }

        [TestMethod]
        public void EqualsFalseNegativeSentimentTest()
        {
            anotherSentiment = new NegativeSentiment("SentimentText");
            Assert.AreNotEqual(aSentiment, anotherSentiment);
        }

        [TestMethod]
        public void EqualsNullNegativeSentimentTest()
        {
            Assert.IsFalse(aSentiment.Equals(null));
        }

        [TestMethod]
        public void NegativeSentimentUnequalHashCodeTest()
        {
            anotherSentiment = new NegativeSentiment("SentimentText");
            Assert.AreNotEqual(aSentiment.GetHashCode(), anotherSentiment.GetHashCode());
        }

        [TestMethod]
        public void NegativeSentimentEqualHashCodeTest()
        {
            anotherSentiment = new NegativeSentiment("SentimentText");
            anotherSentiment.SentimentId = aSentiment.SentimentId;
            Assert.AreEqual(aSentiment.GetHashCode(), anotherSentiment.GetHashCode());
        }

    }
}
