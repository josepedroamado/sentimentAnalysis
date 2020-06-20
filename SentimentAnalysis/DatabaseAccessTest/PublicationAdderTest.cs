using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class PublicationAdderTest
    {
        SystemData data;
        PublicationAdder adder;
        Author anAuthor;

        [TestInitialize]
        public void TestInitialize()
        {
            IAuthorSaver authorSaver = new AuthorDatabaseSaver();
            authorSaver.Clear();
            IAlarmSaver alarmSaver = new AlarmDatabaseSaver();
            alarmSaver.Clear();
            IRelationSaver relationSaver = new RelationDatabaseSaver();
            relationSaver.Clear();
            IPublicationSaver publicationSaver = new PublicationDatabaseSaver();
            publicationSaver.Clear();
            IEntitySaver entitySaver = new EntityDatabaseSaver();
            entitySaver.Clear();
            ISentimentSaver sentimentSaver = new SentimentDatabaseSaver();
            sentimentSaver.Clear();
            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, authorSaver);
            adder = new PublicationAdder(data);
            DateTime birthdate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", birthdate);
            data.authorSaver.Add(anAuthor);
        }

        [TestMethod]
        public void NewPublicationAdderTest()
        {
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddPublicationTest()
        {
            DateTime date = new DateTime();
            adder.Add("sometext", date, anAuthor);
            Assert.AreEqual(1, data.publicationSaver.FetchAll().Count);
        }
    }
}
