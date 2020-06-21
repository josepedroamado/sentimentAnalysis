using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class AlarmDatabaseSaver: IAlarmSaver
    {
        public void Add(Alarm anAlarm)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                if (context.Alarms.Include("Entity").Any(alarm => alarm.AlarmDtoId == anAlarm.AlarmId))
                {
                    throw new ObjectAlreadyExistsException("Alarma");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    AlarmDto newAlarm = convert.ConvertToDto(anAlarm);
                    context.Alarms.Add(newAlarm);
                    context.Entry(newAlarm.Entity).State = EntityState.Unchanged;
                    context.SaveChanges();
                }
            }
        }

        public void Delete(Alarm anAlarm)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                AlarmDto alarmToDelete = context.Alarms.Include("Entity").FirstOrDefault(alarm => alarm.AlarmDtoId == anAlarm.AlarmId);
                if (alarmToDelete == null)
                {
                    throw new ObjectDoesntExistException("Alarma");
                }
                else
                {
                    context.Alarms.Remove(alarmToDelete);
                    context.SaveChanges();
                }
            }
        }

        public List<Alarm> FetchAll()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                List<Alarm> allAlarms = new List<Alarm>();
                foreach (AlarmDto alarm in context.Alarms.Include("Entity"))
                {
                    ObjectConversion convert = new ObjectConversion();
                    allAlarms.Add(convert.ConvertToObject(alarm));
                }
                return allAlarms;
            }
        }

        public Alarm Fetch(Alarm anAlarm)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                AlarmDto fetchedAlarm = context.Alarms.Include("Entity").FirstOrDefault(alarm => alarm.AlarmDtoId == anAlarm.AlarmId);
                if (fetchedAlarm == null)
                {
                    throw new ObjectDoesntExistException("Alarma");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    return convert.ConvertToObject(fetchedAlarm);
                }
            }
        }

        public void Modify(Alarm original, Alarm modified)
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                AlarmDto fetchedAlarm = context.Alarms.Include("Entity").FirstOrDefault(alarm => alarm.AlarmDtoId == original.AlarmId);
                if (fetchedAlarm == null)
                {
                    throw new ObjectDoesntExistException("Alarma");
                }
                else
                {
                    ObjectConversion convert = new ObjectConversion();
                    fetchedAlarm.Active = modified.Active;
                    EntityDto entity = convert.ConvertToDto(modified.Entity);
                    fetchedAlarm.Entity = entity;
                    fetchedAlarm.RequiredPostQuantity = modified.RequiredPostQuantity;
                    fetchedAlarm.TimeFrame = modified.TimeFrame;
                    context.Entry(entity).State = EntityState.Unchanged;
                    context.SaveChanges();
                }
            }
        }

        public void Clear()
        {
            using (SentimentAnalysisContext context = new SentimentAnalysisContext())
            {
                context.Alarms.RemoveRange(context.Alarms);
                context.SaveChanges();
            }
        }
    }
}
