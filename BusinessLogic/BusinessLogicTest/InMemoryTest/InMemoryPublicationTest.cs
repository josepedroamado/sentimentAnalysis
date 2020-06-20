using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryPublicationTest
    {
        IPublicationSaver publicationSaver;
        DateTime aDate;
        Publication aPublication;
        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            DateTime ofAgeDate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", ofAgeDate);

            publicationSaver = new InMemoryPublication();
            aDate = new DateTime(2020, 01, 01);
            aPublication = new Publication("PublicationInMemoryPhrase", aDate, anAuthor);
        }

        [TestMethod]
        public void CreateInMemoryPublicationTest()
        {
            Assert.IsNotNull(publicationSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void PublicationExistsTest()
        {
            publicationSaver.AddPublication(aPublication);
            publicationSaver.AddPublication(aPublication);
        }

        [TestMethod]
        public void DeleteExistingPublicationTest()
        {
            publicationSaver.AddPublication(aPublication);
            publicationSaver.DeletePublication(aPublication);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingPublicationTest()
        {
            publicationSaver.DeletePublication(aPublication);
            Assert.IsNotNull(publicationSaver);
        }

        [TestMethod]
        public void FetchExistingPublicationTest()
        {
            publicationSaver.AddPublication(aPublication);
            Publication fetchedPublication = publicationSaver.FetchPublication(aPublication);
            Assert.IsNotNull(fetchedPublication);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingPublicationTest()
        {
            Assert.IsNotNull(publicationSaver.FetchPublication(aPublication));
        }

        [TestMethod]
        public void ModifyExistingPublicationTest()
        {
            publicationSaver.AddPublication(aPublication);
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication modifiedPublication = new Publication("PublicationInMemoryPhrase2", aDate, anAuthor);
            publicationSaver.ModifyPublication(aPublication, modifiedPublication);
            Publication fetchedPublication = publicationSaver.FetchPublication(aPublication);
            Assert.AreEqual(fetchedPublication.Date, modifiedPublication.Date);
            Assert.AreEqual(fetchedPublication.Phrase, modifiedPublication.Phrase);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingPublicationTest()
        {
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication modifiedPublication = new Publication("PublicationInMemoryPhrase3", aDate, anAuthor);
            publicationSaver.ModifyPublication(aPublication, modifiedPublication);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            publicationSaver.AddPublication(aPublication);
            List<Publication> expectedList = new List<Publication>();
            expectedList.Add(aPublication);
            List<Publication> actualList = publicationSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}

