using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
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
            adder = new PublicationAdder(data);
            DateTime birthdate = new DateTime(2002, 01, 01);
            Sentiment sentiment = new PositiveSentiment("Amo");
            sentimentSaver.Add(sentiment);
            Entity entity = new Entity("Coca-cola");
            entitySaver.Add(entity);
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
            adder.Add("Amo Coca-cola", DateTime.Now, anAuthor);
            Assert.AreEqual(1, data.publicationSaver.FetchAll().Count);
        }
    }
}
