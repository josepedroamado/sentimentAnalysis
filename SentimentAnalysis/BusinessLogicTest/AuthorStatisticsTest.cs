using System;
using BusinessLogic;
using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTest
{
    [TestClass]
    public class AuthorStatisticsTest
    {
        SystemData data;
        AuthorStatistics statistics;
        Author author;
        PublicationAdder publicationAdder;

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

            author = new Author("Juan", "Rodriguez", "JRodriguez", new DateTime(1997, 07, 07));
            authorSaver.Add(author);

            EntityAdder entityAdder = new EntityAdder(data);
            entityAdder.Add("coca-cola");

            SentimentAdder sentimentAdder = new SentimentAdder(data);
            sentimentAdder.Add("Amo", true);
            sentimentAdder.Add("Odio", false);

            publicationAdder = new PublicationAdder(data);

            statistics = new AuthorStatistics(data);

        }

        [TestMethod]
        public void NewAuthorStatisticsTest()
        {
            Assert.IsNotNull(statistics);
        }

        [TestMethod]
        public void SentimentPublictionsPercentageTest()
        {
            publicationAdder.Add("Amo coca-cola", DateTime.Today.AddDays(-2), author);
            publicationAdder.Add("Odio coca-cola", DateTime.Today.AddDays(-2), author);
            int percentage = statistics.SentimentPublictionsPercentage(author.AuthorId, "PositiveSentiment");
            Assert.AreEqual(50, percentage);
        }

        [TestMethod]
        public void SentimentPublictionsPercentageWithNoPublicationsTest()
        {
            int percentage = statistics.SentimentPublictionsPercentage(author.AuthorId, "PositiveSentiment");
            Assert.AreEqual(0, percentage);
        }

        [TestMethod]
        public void EntitiesMentionedTest()
        {
            publicationAdder.Add("Amo coca-cola", DateTime.Today.AddDays(-2), author);
            publicationAdder.Add("Odio coca-cola", DateTime.Today.AddDays(-2), author);
            publicationAdder.Add("Me gusta Pepsi", DateTime.Today.AddDays(-2), author);
            int entitiesMentioned = statistics.EntitiesMentioned(author.AuthorId);
            Assert.AreEqual(1, entitiesMentioned);
        }

        [TestMethod]
        public void DailyPublicationAverageTest()
        {
            publicationAdder.Add("Amo coca-cola", DateTime.Today.AddDays(-4), author);
            publicationAdder.Add("Odio coca-cola", DateTime.Today.AddDays(-3), author);
            publicationAdder.Add("Me gusta Pepsi", DateTime.Today.AddDays(-2), author);
            publicationAdder.Add("Uso Netflix", DateTime.Today.AddDays(-1), author);
            int average = statistics.DailyPublicationAverage(author.AuthorId);
            Assert.AreEqual(1, average);
        }

        [TestMethod]
        public void DailyPublicationAverageWithZeroDaysTest()
        {
            publicationAdder.Add("Amo coca-cola", DateTime.Today.AddHours(-4), author);
            int average = statistics.DailyPublicationAverage(author.AuthorId);
            Assert.AreEqual(1, average);
        }

        [TestMethod]
        public void DailyPublicationAverageWithZeroDaysAndNoPublicationsTest()
        {
            int average = statistics.DailyPublicationAverage(author.AuthorId);
            Assert.AreEqual(0, average);
        }
    }
}
