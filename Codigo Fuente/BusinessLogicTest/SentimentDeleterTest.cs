using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class SentimentDeleterTest
    {
        SystemData data;
        SentimentDeleter sentimentDeleter;

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

            Author author = new Author("Juan", "Rodriguez", "JRodriguez", new DateTime(1997, 07, 07));
            authorSaver.Add(author);

            SentimentAdder sentimentAdder = new SentimentAdder(data);
            sentimentAdder.Add("Amo", true);
            sentimentAdder.Add("Odio", false);

            EntityAdder adder = new EntityAdder(data);
            adder.Add("Coca-cola");
            adder.Add("Pepsi");

            PublicationAdder publicationAdder = new PublicationAdder(data);

            publicationAdder.Add("Amo coca-cola", DateTime.Today.AddDays(-4), author);
            publicationAdder.Add("Odio coca-cola", DateTime.Today.AddDays(-3), author);
            publicationAdder.Add("Me gusta Pepsi", DateTime.Today.AddDays(-2), author);
            publicationAdder.Add("Uso Netflix", DateTime.Today.AddDays(-1), author);         

            sentimentDeleter = new SentimentDeleter(data);
        }

        [TestMethod]
        public void NewSentimentDeleterTest()
        {
            Assert.IsNotNull(sentimentDeleter);
        }

        [TestMethod]
        public void DeleteSentimentTest()
        {
            Sentiment sentiment = data.sentimentSaver.FetchAll()[1];
            sentimentDeleter.Delete(sentiment);
            Assert.AreEqual(2, data.sentimentSaver.FetchAll().Count);
        }
    }
}
