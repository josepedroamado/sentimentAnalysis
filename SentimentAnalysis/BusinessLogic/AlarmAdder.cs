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

        public void Add(Entity selectedEntity, int numberOfPosts, int alarmTime, bool positive, bool hours)
        {
            TimeSpan timeSpan = SetTimeSpan(alarmTime, hours);
            Alarm newAlarm;
            if (positive)
            {
                newAlarm = new PositiveAlarm(selectedEntity, numberOfPosts, timeSpan);
            }
            else
            {
                newAlarm = new NegativeAlarm(selectedEntity, numberOfPosts, timeSpan);
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
