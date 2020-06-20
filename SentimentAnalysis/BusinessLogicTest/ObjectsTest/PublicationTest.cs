using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class PublicationTest
    {
        DateTime aDate;
        Publication aPublication;
        Publication anotherPublication;
        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            aDate = new DateTime(2020, 01, 01);
            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            aPublication = new Publication("PublicationTest1", aDate, anAuthor);
        }
        [TestMethod]
        public void NewPublicationTest()
        {
            Assert.IsNotNull(aPublication);
        }

        [TestMethod]
        public void NewPublicationPhraseTest()
        {
            Assert.AreEqual("PublicationTest1", aPublication.Phrase);
        }

        [TestMethod]
        public void NewPublicationDateTest()
        {
            Assert.AreEqual(aDate, aPublication.Date);
        }

        [TestMethod]
        public void NewPublicationAuthorTest()
        {
            Assert.AreEqual(anAuthor, aPublication.Author);
        }

        [TestMethod]
        public void EqualsTruePublicationTest()
        {
            Assert.AreEqual(aPublication, aPublication);
        }

        [TestMethod]
        public void EqualsFalsePublicationTest()
        {
            anotherPublication = new Publication("PublicationTest3", aDate, anAuthor);
            Assert.AreNotEqual(aPublication, anotherPublication);
        }

        [TestMethod]
        public void EqualsNullPublicationTest()
        {
            Assert.IsFalse(aPublication.Equals(null));
        }

        [TestMethod]
        public void PublicationUnequalHashCodeTest()
        {
            anotherPublication = new Publication("PublicationTest4", aDate, anAuthor);
            Assert.AreNotEqual(aPublication.GetHashCode(), anotherPublication.GetHashCode());
        }

        [TestMethod]
        public void PublicationEqualHashCodeTest()
        {
            anotherPublication = new Publication("PublicationTest5", aDate, anAuthor);
            anotherPublication.PublicationId = aPublication.PublicationId;
            Assert.AreEqual(aPublication.GetHashCode(), anotherPublication.GetHashCode());
        }
        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void PublicationTextToShortTest()
        {
            String name = "";
            Publication aPublication = new Publication(name, aDate, anAuthor);
        }
        [TestMethod]
        [ExpectedException(typeof(TextTooLongException))]
        public void PublicationTextToLongTest()
        {
            String name = "";
            while (name.Length < 100)
            {
                name = name + "assdda";
            }
            Publication aPublication = new Publication(name,aDate, anAuthor);
        }
    }
}
