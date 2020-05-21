using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class AlarmAdder
    {
        public AlarmAdder(SystemData data, Entity selectedEntity, int numberOfPosts, int alarmTime, bool positive, bool hours)
        {
            Alarm alarmToAdd = CreateAlarm(selectedEntity, numberOfPosts, alarmTime, positive, hours);
            AddAlarm(data, alarmToAdd);
        }
        private Alarm CreateAlarm(Entity selectedEntity, int numberOfPosts, int alarmTime, bool positive, bool hours)
        {
            TimeSpan timeSpan = SetTimeSpan(alarmTime, hours);
            Alarm alarmToAdd;
            if(positive)
            {
                alarmToAdd = new PositiveAlarm(selectedEntity, numberOfPosts, timeSpan);
            }
            else
            {
                alarmToAdd = new NegativeAlarm(selectedEntity, numberOfPosts, timeSpan);
            }
            return alarmToAdd;
        }
        private void AddAlarm(SystemData data, Alarm alarmToSave)
        {
            data.alarmSaver.AddAlarm(alarmToSave);
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
                timeSpan = new TimeSpan(alarmTime*24, 0, 0);
            }
            return timeSpan;
        }
    }
}
