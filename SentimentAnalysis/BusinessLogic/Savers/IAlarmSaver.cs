using System;
using System.Collections.Generic;

namespace BusinessLogic
{
    public interface IAlarmSaver
    {
        void Add(Alarm anAlarm);

        void Delete(Alarm anAlarm);

        void Modify(Alarm original, Alarm modified);

        Alarm Fetch(Alarm anAlarm);

        List<Alarm> FetchAll();

        List<Alarm> FetchAllOfEntity(Guid entityId);

        void Clear();
    }
}
