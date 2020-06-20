using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorTest
    {

        DateTime ofAgeDate;
        [TestInitialize]
        public void TestInitialize()
        {
            ofAgeDate = new DateTime(1997, 6, 7);
        }
        [TestMethod]
        public void AuthorIsNotNullTest()
        {
            Author actualAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            Assert.IsNotNull(actualAuthor);
        }
        [TestMethod]
        public void AuthorIsUserNameOkTest()
        {
            Author actualAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            Assert.AreEqual(actualAuthor.UserName,"James45");
        }
        [TestMethod]
        public void AuthorIsNameOkTest()
        {
            Author actualAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            Assert.AreEqual(actualAuthor.Name, "James");
        }
        [TestMethod]
        public void AuthorIsLastNameOkTest()
        {
            Author actualAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            Assert.AreEqual(actualAuthor.LastName, "Doe");
        }
        [TestMethod]
        public void AuthorIsAgeEqualTest()
        {
            Author actualAuthor = new Author("James45", "James", "Doe", ofAgeDate);
            Assert.AreEqual(actualAuthor.BirthDate, ofAgeDate);
        }
        [TestMethod]
        [ExpectedException(typeof(AgeTooShortException))]
        public void AuthorIsNotOfAgeTest()
        {
            DateTime notOfAge = new DateTime(2012, 6, 7);
            Author actualAuthor = new Author("James45", "James", "Doe", notOfAge);
        }
        [TestMethod]
        [ExpectedException(typeof(AgeTooLongException))]
        public void AuthorIsOverAgeTest()
        {
            DateTime notOfAge = new DateTime(1912, 6, 7);
            Author actualAuthor = new Author("James45", "James", "Doe", notOfAge);
        }
    }
}
