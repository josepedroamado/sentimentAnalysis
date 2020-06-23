using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class SystemDataTest
    {
        SystemData data;

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
        }

        [TestMethod]
        public void NewSystemDataTest()
        {
            Assert.IsNotNull(data);
        }
    }
}
