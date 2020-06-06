using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IAlarmSaver
    {
        void AddAlarm(Alarm anAlarm);

        void DeleteAlarm(Alarm anAlarm);

        void ModifyAlarm(Alarm original, Alarm modified);

        Alarm FetchAlarm(Alarm anAlarm);

        List<Alarm> FetchAll();
    }
}
