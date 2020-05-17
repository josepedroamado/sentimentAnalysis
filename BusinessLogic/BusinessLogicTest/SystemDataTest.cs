using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class SystemDataTest
    {
        IEntitySaver entitySaver;
        ISentimentSaver sentimentSaver;
        IPublicationSaver publicationSaver;

        [TestInitialize]
        public void TestInitialize()
        {
            entitySaver = new InMemoryEntity();
            //sentimentSaver = new InMemorySentiment();
            publicationSaver = new InMemoryPublication();
        }
        [TestMethod]
        public void NewSystemDataTest()
        {
            SystemData systemData = new SystemData(entitySaver, sentimentSaver, publicationSaver);
            Assert.IsNotNull(systemData);
        }
    }
}
