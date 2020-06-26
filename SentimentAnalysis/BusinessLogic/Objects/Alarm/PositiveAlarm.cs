using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class PositiveAlarm : Alarm
    {
        public PositiveAlarm(Entity aEntity, int aRequiredPostQuantity, TimeSpan aTimeSpan)
        {
            AlarmId = Guid.NewGuid();
            Entity = aEntity;
            RequiredPostQuantity = aRequiredPostQuantity;
            TimeFrame = aTimeSpan.Ticks;
            Active = false;
        }
    }
}
