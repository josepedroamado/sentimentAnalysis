using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class EntityAdderTest
    {
        SystemData data;
        EntityAdder adder;

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
            adder = new EntityAdder(data);
        }

        [TestMethod]
        public void NewEntityAdderTest()
        {
            adder.Add("text");
            Assert.IsNotNull(adder);
        }

        [TestMethod]
        public void AddTest()
        {
            adder.Add("sometext");
            Entity expectedEntity = new Entity("sometext");
            Assert.AreEqual(2, data.entitySaver.FetchAll().Count);
        }
    }
}
