using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityDeleterTest
    {
        SystemData data;       
        EntityDeleter entityDeleter;

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

            AlarmAdder alarmAdder = new AlarmAdder(data);
            alarmAdder.Add(data.entitySaver.FetchAll()[1], 1, 2, "Positiva", false, null);

            entityDeleter = new EntityDeleter(data);
        }

        [TestMethod]
        public void NewEntityDeleterTest()
        {
            Assert.IsNotNull(entityDeleter);
        }

        [TestMethod]
        public void DeleteEntityTest()
        {
            Entity entity = data.entitySaver.FetchAll()[1];
            entityDeleter.Delete(entity);
            Assert.AreEqual(2, data.entitySaver.FetchAll().Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void DeleteNonExistingEntityTest()
        {
            Entity entity = new Entity("Salus");
            entityDeleter.Delete(entity);
            data.entitySaver.Fetch(entity);
        }
    }
}
