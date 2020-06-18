using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;


namespace BusinessLogicTest
{
    [TestClass]
    public class PositiveSentimentTest
    {
        PositiveSentiment aSentiment;
        Sentiment anotherSentiment;

        [TestInitialize]
        public void TestInitialize()
        {
            aSentiment = new PositiveSentiment("AText");
        }

        [TestMethod]
        public void NewPositiveSentimentTest()
        {           
            Assert.IsNotNull(aSentiment);
        }

        [TestMethod]
        public void NewPositiveSentimentTextTest()
        {
            Assert.AreEqual(aSentiment.Text, "AText");
        }
        
        [TestMethod]
        [ExpectedException(typeof(TextTooLongException))]
        public void TextBiggerThanMaxTest()
        {
            String AText = "1";
            while(AText.Length<=100)
            {
                AText = AText + "more characters";
            }
            PositiveSentiment ASentiment = new PositiveSentiment(AText);
        }
        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void TextShorterThanMaxTest()
        {
            String AText = "1";
            PositiveSentiment ASentiment = new PositiveSentiment(AText);
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void TextEmptyTest()
        {
            String AText = " ";
            PositiveSentiment ASentiment = new PositiveSentiment(AText);
        }

        [TestMethod]
        public void NewPositiveSentimentNextIdTest()
        {
            int nextId = aSentiment.GetNextId();
            anotherSentiment = new PositiveSentiment("SentimentText");
            Assert.AreEqual(anotherSentiment.SentimentId, nextId);
        }

        [TestMethod]
        public void EqualsTruePositiveSentimentTest()
        {
            Assert.AreEqual(aSentiment, aSentiment);
        }

        [TestMethod]
        public void EqualsFalsePositiveSentimentTest()
        {
            anotherSentiment = new PositiveSentiment("SentimentText");
            Assert.AreNotEqual(aSentiment, anotherSentiment);
        }

        [TestMethod]
        public void EqualsNullPositiveSentimentTest()
        {
            Assert.IsFalse(aSentiment.Equals(null));
        }

        [TestMethod]
        public void PositiveSentimentUnequalHashCodeTest()
        {
            anotherSentiment = new PositiveSentiment("SentimentText");
            Assert.AreNotEqual(aSentiment.GetHashCode(), anotherSentiment.GetHashCode());
        }

        [TestMethod]
        public void PositiveSentimentEqualHashCodeTest()
        {
            anotherSentiment = new PositiveSentiment("SentimentText");
            anotherSentiment.SentimentId = aSentiment.SentimentId;
            Assert.AreEqual(aSentiment.GetHashCode(), anotherSentiment.GetHashCode());
        }
    }
}
