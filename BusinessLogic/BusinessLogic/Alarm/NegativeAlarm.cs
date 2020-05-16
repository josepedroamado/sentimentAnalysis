using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class NegativeAlarm : Alarm
    {
        public NegativeAlarm(Entity aEntity, int aRequiredPostQuantity, TimeSpan aTimeSpan)
        {
            this.Entity = aEntity;
            this.RequiredPostQuantity = aRequiredPostQuantity;
            this.TimeFrame = aTimeSpan;
            this.Active = false;
        }
    }
}
