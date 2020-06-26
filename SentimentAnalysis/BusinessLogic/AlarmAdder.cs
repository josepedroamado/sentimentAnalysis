using System;

namespace BusinessLogic
{
    public class AlarmAdder
    {
        private SystemData data;

        public AlarmAdder(SystemData data)
        {
            this.data = data;
        }

        public void Add(Entity selectedEntity, int numberOfPosts, int alarmTime, string alarmType, bool hours, string phrasesType)
        {
            TimeSpan timeSpan = SetTimeSpan(alarmTime, hours);
            Alarm newAlarm;
            if (alarmType == "Positiva")
            {
                newAlarm = new PositiveAlarm(selectedEntity, numberOfPosts, timeSpan);
            }
            else if(alarmType == "Negativa")
            {
                newAlarm = new NegativeAlarm(selectedEntity, numberOfPosts, timeSpan);
            }
            else
            {
                newAlarm = new AuthorAlarm(selectedEntity, numberOfPosts, timeSpan, phrasesType);
            }

            data.alarmSaver.Add(newAlarm);
            AlarmAnalyzer alarmAnalyzer = new AlarmAnalyzer(data);
            alarmAnalyzer.AnalyzeAlarm(newAlarm);
        }

        private TimeSpan SetTimeSpan(int alarmTime, bool hours)
        {
            TimeSpan timeSpan;
            if (hours)
            {
                timeSpan = new TimeSpan(alarmTime,0,0);
            }
            else
            {
                timeSpan = new TimeSpan(alarmTime, 0, 0, 0);
            }
            return timeSpan;
        }
    }
}
