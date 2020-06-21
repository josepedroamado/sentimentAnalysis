﻿using System;
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
            publicationSaver.Clear();
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
            publicationSaver.Add(aPublication);
            publicationSaver.Add(aPublication);
        }

        [TestMethod]
        public void DeleteExistingPublicationTest()
        {
            publicationSaver.Add(aPublication);
            publicationSaver.Delete(aPublication);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingPublicationTest()
        {
            publicationSaver.Delete(aPublication);
            Assert.IsNotNull(publicationSaver);
        }

        [TestMethod]
        public void FetchExistingPublicationTest()
        {
            publicationSaver.Add(aPublication);
            Publication fetchedPublication = publicationSaver.Fetch(aPublication);
            Assert.IsNotNull(fetchedPublication);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingPublicationTest()
        {
            Assert.IsNotNull(publicationSaver.Fetch(aPublication));
        }

        [TestMethod]
        public void ModifyExistingPublicationTest()
        {
            publicationSaver.Add(aPublication);
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication modifiedPublication = new Publication("PublicationInMemoryPhrase2", aDate, anAuthor);
            publicationSaver.Modify(aPublication, modifiedPublication);
            Publication fetchedPublication = publicationSaver.Fetch(aPublication);
            Assert.AreEqual(fetchedPublication.Date, modifiedPublication.Date);
            Assert.AreEqual(fetchedPublication.Phrase, modifiedPublication.Phrase);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingPublicationTest()
        {
            DateTime anotherDate = new DateTime(2022, 01, 01);
            Publication modifiedPublication = new Publication("PublicationInMemoryPhrase3", aDate, anAuthor);
            publicationSaver.Modify(aPublication, modifiedPublication);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            publicationSaver.Add(aPublication);
            List<Publication> expectedList = new List<Publication>();
            expectedList.Add(aPublication);
            List<Publication> actualList = publicationSaver.FetchAll();
            Assert.IsTrue(expectedList.SequenceEqual(actualList));
        }
    }
}
