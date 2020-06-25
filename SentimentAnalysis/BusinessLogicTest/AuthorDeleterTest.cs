using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using DataAccess;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorDeleterTest
    {
        SystemData data;
        PublicationAdder publicationAdder;
        AuthorDeleter authorDeleter;

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

            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);

            AuthorAdder authorAdder = new AuthorAdder(data);
            authorAdder.Add("Juan", "Perez", "JPerez", new DateTime(1997, 07, 07));
            authorAdder.Add("Roberto", "Rodriguez", "RRodriguez", new DateTime(1997, 07, 07));

            EntityAdder entityAdder = new EntityAdder(data);
            entityAdder.Add("coca-cola");

            SentimentAdder sentimentAdder = new SentimentAdder(data);
            sentimentAdder.Add("Amo", true);
            sentimentAdder.Add("Odio", false);

            publicationAdder = new PublicationAdder(data);

            authorDeleter = new AuthorDeleter(data);
        }

        [TestMethod]
        public void NewAuthorDeleterTest()
        {
            Assert.IsNotNull(authorDeleter);
        }

        [TestMethod]
        public void DeleteAuthorTest()
        {
            Author author = data.authorSaver.FetchAll()[0];
            publicationAdder.Add("Amo coca-cola", DateTime.Today.AddDays(-4), author);
            publicationAdder.Add("Odio coca-cola", DateTime.Today.AddDays(-3), author);
            publicationAdder.Add("Me gusta Pepsi", DateTime.Today.AddDays(-2), author);
            publicationAdder.Add("Uso Netflix", DateTime.Today.AddDays(-1), author);
            authorDeleter.Delete(author);
            Assert.AreEqual(1, data.authorSaver.FetchAll().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingAuthorTest()
        {
            Author author = new Author("afame", "asame", "ername", new DateTime(1997, 07, 07));
            authorDeleter.Delete(author);
        }
    }
}

