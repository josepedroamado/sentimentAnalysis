using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class InMemoryAlarm: IAlarmSaver
    {
        private List<Alarm> Alarms;

        public InMemoryAlarm()
        {
            this.Alarms = new List<Alarm>();
        }
        public void AddAlarm(Alarm anAlarm)
        {
            if (!AlarmExists(anAlarm)) Alarms.Add(anAlarm);
            else throw new ObjectAlreadyExistsException("Alarma");
        }

        public void DeleteAlarm(Alarm anAlarm)
        {
            if (AlarmExists(anAlarm)) Alarms.Remove(anAlarm);
            else throw new ObjectDoesntExistException("Alarma");
        }

        public void ModifyAlarm(Alarm original, Alarm modified)
        {
            if (AlarmExists(original))
            {
                Alarms[GetAlarmListIndex(original)].Active = modified.Active;
                Alarms[GetAlarmListIndex(original)].Entity = modified.Entity;
                Alarms[GetAlarmListIndex(original)].RequiredPostQuantity = modified.RequiredPostQuantity;
                Alarms[GetAlarmListIndex(original)].TimeFrame = modified.TimeFrame;
            }
            else throw new ObjectDoesntExistException("Alarma");
        }

        public Alarm FetchAlarm(Alarm anAlarm)
        {
            if (AlarmExists(anAlarm)) return Alarms[GetAlarmListIndex(anAlarm)];
            else throw new ObjectDoesntExistException("Alarma");
        }

        private int GetAlarmListIndex(Alarm anAlarm)
        {
            return Alarms.IndexOf(anAlarm);
        }

        private bool AlarmExists(Alarm anAlarm)
        {
            return Alarms.Contains(anAlarm);
        }
    }
}
