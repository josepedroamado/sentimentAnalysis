using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class PublicationDatabaseSaverTest
    {
        IAlarmSaver alarmSaver;
        IRelationSaver relationSaver;
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;
        IAuthorSaver authorSaver;
        DateTime aDate;
        Publication aPublication;

        [TestInitialize]
        public void TestInitialize()
        {
            alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
            authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();

            aDate = new DateTime(2020, 01, 01);
            aPublication = new Publication("PublicationPhrase", aDate);

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
            Publication modifiedPublication = new Publication("PublicationPhrase2", aDate);
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
            Publication modifiedPublication = new Publication("PublicationPhrase3", aDate);
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
