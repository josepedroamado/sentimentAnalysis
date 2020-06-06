using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return data.relationSaver.FetchAll().FindAll(
                    relation => (relation.Entity == alarm.Entity &&
                                 relation.Sentiment.GetType().Name == sentimentType &&
                                 relation.Publication.Date >= lowerDateBoundary
                                )
                );
        }
    }
}
