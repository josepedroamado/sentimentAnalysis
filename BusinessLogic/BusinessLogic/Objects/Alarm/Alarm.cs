using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Alarm
    {
        public static int NextId = 1;

        public int AlarmId { get; set; }

        public Entity Entity { get; set; }

        public int RequiredPostQuantity { get; set; }

        public TimeSpan TimeFrame { get; set; }

        public bool Active { get; set; }

        public int GetNextId()
        {
            return NextId;
        }

        public override bool Equals(object obj)
        {
            Alarm alarm = obj as Alarm;
            if (alarm != null) return this.AlarmId == alarm.AlarmId;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.AlarmId.GetHashCode();
        }
    }
}
