using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AlarmAnalyzer
    {
        IRelationSaver relationSaver;

        public AlarmAnalyzer(IRelationSaver relationSaver)
        {
            this.relationSaver = relationSaver;
        }

        public void AnalyzeAlarm(Alarm alarm)
        {
            String alarmType = alarm.GetType().Name;
            String sentimentType = "NeutralSentiment";
            if (alarmType == "PositiveAlarm") sentimentType = "PositiveSentiment";
            if (alarmType == "NegativeAlarm") sentimentType = "NegativeSentiment";
            DateTime lowerDateBoundary = DateTime.Now - alarm.TimeFrame;
            List<Relation> relations = GetMatchingRelations(alarm, sentimentType, lowerDateBoundary);
            if (relations.Count() >= alarm.RequiredPostQuantity)
            {
                alarm.Active = true;
            }
            else alarm.Active = false;
        }

        public List<Relation> GetMatchingRelations(Alarm alarm, String sentimentType, DateTime lowerDateBoundary)
        {
            return relationSaver.FetchAll().FindAll(
                    relation => relation.Entity == alarm.Entity &&
                    relation.Sentiment.GetType().Name == sentimentType &&
                    relation.Publication.Date >= lowerDateBoundary
                );
        }
    }
}
