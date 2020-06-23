using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorDeleterTest
    {
        DateTime ofAge;
        SystemData data;
        AuthorDeleter deleter;

        [TestInitialize]
        public void TestInitialize()
        {
            IRelationSaver relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            IPublicationSaver publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            IAuthorSaver authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            IAlarmSaver alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            IEntitySaver entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            ISentimentSaver sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();

            ofAge = new DateTime(1997, 07, 07);
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);
            AuthorAdder adder = new AuthorAdder(data);
            adder.Add("firstname", "lastName", "username", ofAge);
            adder.Add("afirstname", "alastName", "ausername", ofAge);
            deleter = new AuthorDeleter(data);
        }

        [TestMethod]
        public void NewAuthorDeleterTest()
        {
            Assert.IsNotNull(deleter);
        }

        [TestMethod]
        public void DeleteAuthorTest()
        {
            Author author = new Author("username", "firstname", "lastName",  ofAge);
            author.AuthorId = data.authorSaver.FetchAll()[0].AuthorId;
            deleter.Delete(author);
            Assert.AreEqual(1, data.authorSaver.FetchAll().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAuthorTest()
        {
            Author author = new Author("afame", "asame", "ername", ofAge);
            deleter.Delete(author);
        }
    }
}

