using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class AlarmAnalyzer
    {
        private SystemData data;

        public AlarmAnalyzer(SystemData data)
        {
            this.data = data;
        }

        public void AnalyzeAllAlarms()
        {
            List<Alarm> alarms = data.alarmSaver.FetchAll();
            foreach (Alarm alarm in alarms)
            {
                AnalyzeAlarm(alarm);
            }
        }

        public void AnalyzeAlarm(Alarm alarm)
        {
            string sentimentType = AnalyzeSentimentType(alarm);
            DateTime lowerDateBoundary = CalculateLowerDateBoundary(alarm);
            int relations = GetMatchingRelations(alarm, sentimentType, lowerDateBoundary);
            if (relations >= alarm.RequiredPostQuantity)
            {
                alarm.Active = true;
                data.alarmSaver.Modify(alarm, alarm);
            }
            else
            {
                alarm.Active = false;
                data.alarmSaver.Modify(alarm, alarm);
            }
        }

        private string AnalyzeSentimentType(Alarm alarm)
        {
            string alarmType = alarm.GetType().Name;
            string sentimentType = "NeutralSentiment";
            if (alarmType == "PositiveAlarm") sentimentType = "PositiveSentiment";
            if (alarmType == "NegativeAlarm") sentimentType = "NegativeSentiment";
            if (alarmType == "AuthorAlarm")
            {
                AuthorAlarm theAlarm = (AuthorAlarm)alarm;
                if (theAlarm.PhrasesType == "Positivas")
                {
                    sentimentType = "PositiveSentiment";
                }
                else
                {
                    sentimentType = "NegativeSentiment";
                }

            }
            return sentimentType;
        }

        private DateTime CalculateLowerDateBoundary(Alarm alarm)
        {
            TimeSpan timeframe = new TimeSpan(alarm.TimeFrame);
            DateTime lowerDateBoundary = DateTime.Now - timeframe;
            return lowerDateBoundary;
        }

        private int GetMatchingRelations(Alarm alarm, string sentimentType, DateTime lowerDateBoundary)
        {
            return data.relationSaver.FetchAll().FindAll(
                    relation => (relation.Entity.Equals(alarm.Entity) &&
                                 relation.Sentiment.GetType().Name == sentimentType &&
                                 relation.Publication.Date >= lowerDateBoundary
                                )
                ).Count;
        }

        public List<Author> GetMatchingRelationsAuthors(Alarm alarm)
        {
            string sentimentType = AnalyzeSentimentType(alarm);
            DateTime lowerDateBoundary = CalculateLowerDateBoundary(alarm);
            List<Relation> relations = data.relationSaver.FetchAll().FindAll(
                    relation => (relation.Entity.Equals(alarm.Entity) &&
                                 relation.Sentiment.GetType().Name == sentimentType &&
                                 relation.Publication.Date >= lowerDateBoundary
                                )
                );
            List<Author> authors = new List<Author>();
            foreach (Relation relation in relations)
            {
                if (!authors.Contains(relation.Publication.Author))
                {
                    authors.Add(relation.Publication.Author);
                }
            }
            return authors;
        }
    }
}
