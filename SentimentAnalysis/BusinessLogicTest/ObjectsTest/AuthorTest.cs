using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorTest
    {
        DateTime birthdate;
        Author author;

        [TestInitialize]
        public void TestInitialize()
        {
            birthdate = new DateTime(1997, 6, 7);
            author = new Author("James45", "James", "Doe", birthdate);
        }

        [TestMethod]
        public void AuthorIsNotNullTest()
        {
            Assert.IsNotNull(author);
        }

        [TestMethod]
        public void AuthorGetIdTest()
        {
            Assert.IsNotNull(author.AuthorId);
        }

        [TestMethod]
        public void AuthorVerifyUserNameTest()
        {
            Assert.AreEqual(author.UserName,"James45");
        }

        [TestMethod]
        public void AuthorVerifyFirstNameTest()
        {
            Assert.AreEqual(author.FirstName, "James");
        }

        [TestMethod]
        public void AuthorVerifyLastNameTest()
        {
            Assert.AreEqual(author.LastName, "Doe");
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooLongException))]
        public void AuthorVerifyFirstNameTooLongTest()
        {
            Author newAuthor = new Author("James45", "James1234567890123456", "Doe", birthdate);
        }

        [TestMethod]
        [ExpectedException(typeof(TextTooShortException))]
        public void AuthorVerifyLastNameTooShortTest()
        {
            Author newAuthor = new Author("James45", "James", "", birthdate);
        }

        [TestMethod]
        public void AuthorVerifyAgeTest()
        {
            Assert.AreEqual(author.BirthDate, birthdate);
        }

        [TestMethod]
        public void AuthorVerifyAgeDateBeforeBirthdateTest()
        {
            Author newAuthor = new Author("James45", "James", "Doe", DateTime.Today.AddMonths(1).AddYears(-50));
            Assert.AreEqual(49, newAuthor.CalculateAge(newAuthor.BirthDate));
        }

        [TestMethod]
        [ExpectedException(typeof(TooYoungException))]
        public void AuthorIsTooYoungTest()
        {
            Author newAuthor = new Author("James45", "James", "Doe", new DateTime(2012, 6, 7));
        }

        [TestMethod]
        [ExpectedException(typeof(TooOldException))]
        public void AuthorIsTooOldTest()
        {
            Author newAuthor = new Author("James45", "James", "Doe", new DateTime(1912, 6, 7));
        }

        [TestMethod]
        public void AuthorEqualsTrueTest()
        {
            Assert.IsTrue(author.Equals(author));
        }

        [TestMethod]
        public void AuthorEqualsFalseTest()
        {
            Author newAuthor = new Author("johnny", "John", "Doe", birthdate);
            Assert.IsFalse(author.Equals(newAuthor));
        }

        [TestMethod]
        public void AuthorEqualsNullTest()
        {
            Assert.IsFalse(author.Equals(null));
        }

        [TestMethod]
        public void AuthorGetHashEqualTest()
        {
            Assert.IsTrue(author.GetHashCode().Equals(author.GetHashCode()));
        }

        [TestMethod]
        public void AuthorGetHashDifferentTest()
        {
            Author secondAuthor = new Author("johnny", "John", "Doe", birthdate);
            Assert.IsFalse(author.GetHashCode().Equals(secondAuthor.GetHashCode()));
        }
    }
}
