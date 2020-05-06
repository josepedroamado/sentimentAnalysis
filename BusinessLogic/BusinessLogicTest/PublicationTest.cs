using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationTest
    {
        [TestMethod]
        public void NewPublicationTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("APhrase", aDate, 1);
            Assert.IsNotNull(aPublication);
        }

        [TestMethod]
        public void NewPublicationPhraseTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("APhrase", aDate, 1);
            Assert.AreEqual("APhrase", aPublication.Phrase);
        }

        [TestMethod]
        public void NewPublicationDateTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("APhrase", aDate, 1);
            Assert.AreEqual(aDate, aPublication.Date);
        }

        [TestMethod]
        public void NewPublicationIdTest()
        {
            DateTime aDate = new DateTime(2020, 01, 01);
            Publication aPublication = new Publication("APhrase", aDate, 1);
            Assert.AreEqual(1, aPublication.Id);
        }
    }
}
