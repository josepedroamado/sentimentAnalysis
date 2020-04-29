using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;


namespace BusinessLogicTest
{
    [TestClass]
    public class PositiveSentimentTest
    {
        [TestMethod]
        public void NewPositiveSentimentTitleTest()
        {
            PositiveSentiment ASentiment = new PositiveSentiment(1, "AText");
            Assert.AreEqual(ASentiment.Id , 1);
        }
        [TestMethod]
        public void NewPositiveSentimentTextTest()
        {
            PositiveSentiment ASentiment = new PositiveSentiment(1, "AText");
            Assert.AreEqual(ASentiment.Text, "AText");
        }
        [TestMethod]
        public void EqualOverrideTest()
        {
            PositiveSentiment ASentiment = new PositiveSentiment(1, "AText");
            PositiveSentiment OtherSentiment = new PositiveSentiment(1, "AText");
            Assert.AreEqual(ASentiment , OtherSentiment);
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
            PositiveSentiment ASentiment = new PositiveSentiment(1, AText);
        }
        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void TextShorterThanMaxTest()
        {
            String AText = "1";
            PositiveSentiment ASentiment = new PositiveSentiment(1, AText);
        }

    }
}
