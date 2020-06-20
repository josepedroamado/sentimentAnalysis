using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class AuthorDatabaseSaverTest
    {
        IAlarmSaver alarmSaver;
        IRelationSaver relationSaver;
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;
        IAuthorSaver authorSaver;
        Author firstAuthor;
        Author secondAuthor;

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
            firstAuthor = new Author("user1", "First", "User", new DateTime(1985, 6, 6));
            secondAuthor = new Author("user2", "Second", "User", new DateTime(1999, 9, 16));
        }

        [TestMethod]
        public void NewAuthorDatabaseSaverTest()
        {
            Assert.IsNotNull(authorSaver);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void AddNewAuthorTest()
        {
            authorSaver.Add(firstAuthor);
            authorSaver.Add(firstAuthor);
        }

        [TestMethod]
        public void DeleteExistingAuthorTest()
        {
            authorSaver.Add(firstAuthor);
            authorSaver.Delete(firstAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAlarmTest()
        {
            authorSaver.Delete(secondAuthor);
        }

        [TestMethod]
        public void FetchExistingAuthorTest()
        {
            authorSaver.Add(firstAuthor);
            Author fetchedAuthor = authorSaver.Fetch(firstAuthor.AuthorId);
            Assert.IsNotNull(fetchedAuthor);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void FetchNonExistingAuthorTest()
        {
            Assert.IsNotNull(authorSaver.Fetch(secondAuthor.AuthorId));
        }

        [TestMethod]
        public void ModifyExistingAuthorTest()
        {
            authorSaver.Add(firstAuthor);
            Author modifiedAuthor = new Author("newsrname", "NewFirstName", "NewLastName", new DateTime(1999, 12, 12));
            authorSaver.Modify(firstAuthor, modifiedAuthor);
            Author fetchedAuthor = authorSaver.Fetch(firstAuthor.AuthorId);
            Assert.AreEqual(fetchedAuthor.BirthDate, modifiedAuthor.BirthDate);
            Assert.AreEqual(fetchedAuthor.FirstName, modifiedAuthor.FirstName);
            Assert.AreEqual(fetchedAuthor.LastName, modifiedAuthor.LastName);
            Assert.AreEqual(fetchedAuthor.UserName, modifiedAuthor.UserName);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void ModifyNonExistingAuthorTest()
        {
            Author modifiedAuthor = new Author("newsrname", "NewFirstName", "NewLastName", new DateTime(1999, 12, 12));
            authorSaver.Modify(firstAuthor, modifiedAuthor);
        }

        [TestMethod]
        public void FetchAllTest()
        {
            authorSaver.Add(firstAuthor);
            authorSaver.Add(secondAuthor);
            Assert.AreEqual(2, authorSaver.FetchAll().Count);
        }
    }
}
