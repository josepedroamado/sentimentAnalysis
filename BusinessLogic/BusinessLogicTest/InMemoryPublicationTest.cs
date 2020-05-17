using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BusinessLogic;

namespace BusinessLogicTest
{
    [TestClass]
    public class InMemoryPublicationTest
    {
        [TestMethod]
        public void CreateInMemoryPublicationTest()
        {
            IPublicationSaver aPublicationSaver = new InMemoryPublication();
            Assert.IsNotNull(aPublicationSaver);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectAlreadyExistsException))]
        public void PublicationExistsTest()
        {
            IPublicationSaver aPublicationSaver = new InMemoryPublication();
            DateTime aDate = new DateTime();
            Publication aPublication = new Publication("aPhrase", aDate, 1);
            aPublicationSaver.AddPublication(aPublication);
            aPublicationSaver.AddPublication(aPublication);
            Assert.IsNotNull(aPublicationSaver);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void PublicationDeleteNotExistsTest()
        {
            IPublicationSaver aPublicationSaver = new InMemoryPublication();
            aPublicationSaver.DeletePublication(1);
        }
        [TestMethod]
        public void PublicationFetchTest()
        {
            IPublicationSaver aPublicationSaver = new InMemoryPublication();
            DateTime aDate = new DateTime();
            Publication aPublication = new Publication("aPhrase", aDate, 1);
            aPublicationSaver.AddPublication(aPublication);
            Publication recieved = aPublicationSaver.FetchPublication(1);
            Assert.AreEqual(aPublication, recieved);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void PublicationFetchNoPublicationTest()
        {
            IPublicationSaver aPublicationSaver = new InMemoryPublication();
            DateTime aDate = new DateTime();
            Publication aPublication = new Publication("aPhrase", aDate, 1);
            Publication recieved = aPublicationSaver.FetchPublication(1);
            Assert.AreEqual(aPublication, recieved);
        }
        [TestMethod]
        [ExpectedException(typeof(ObjectDoesntExistException))]
        public void PublicationDeleteTest()
        {
            IPublicationSaver aPublicationSaver = new InMemoryPublication();
            DateTime aDate = new DateTime();
            Publication aPublication = new Publication("aPhrase", aDate, 1);
            aPublicationSaver.AddPublication(aPublication);
            aPublicationSaver.DeletePublication(1);
            Publication recieved = aPublicationSaver.FetchPublication(1);
            Assert.AreEqual(aPublication, recieved);
        }
    }
}

