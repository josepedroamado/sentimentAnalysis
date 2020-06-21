using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DatabaseAccessTest
{
    [TestClass]
    public class RelationAdderTest
    {
        SystemData data;
        RelationAdder relationAdder;
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

            data = new SystemData(entitySaver, sentimentSaver, publicationSaver, relationSaver, alarmSaver, null);
            relationAdder = new RelationAdder(data);

            DateTime birthdate = new DateTime(2002, 01, 01);
            anAuthor = new Author("James45", "James", "Doe", birthdate);
            authorSaver.Add(anAuthor);
        }

        [TestMethod]
        public void NewRelationAdderTest()
        {
            Assert.IsNotNull(relationAdder);
        }

        [TestMethod]
        public void AddRelationTest()
        {
            Publication publication = new Publication("Amo Coca-Cola.", DateTime.Now, anAuthor);
            relationAdder.Add(publication);
            Assert.AreEqual(1, data.relationSaver.FetchAll());
        }
    }
}
