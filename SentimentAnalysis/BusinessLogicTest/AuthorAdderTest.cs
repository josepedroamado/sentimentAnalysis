using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorAdderTest
    {
        SystemData data;
        AuthorAdder adder;

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
            adder = new AuthorAdder(data);
        }

        [TestMethod]
        public void NewAuthorAdderTest()
        {
            DateTime aDate = new DateTime(1997, 3, 7);
            adder.Add("username", "firstname", "lastname", aDate);
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddTest()
        {
            DateTime aDate = new DateTime(1997, 3, 7);
            adder.Add("firstname", "lastname", "username", aDate);
            Author expectedAuthor = new Author("username", "firstname", "lastname", aDate);
            Assert.AreEqual(expectedAuthor.UserName, data.authorSaver.FetchAll()[0].UserName);
        }
    }
}
