using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Alarm
    {
        public Entity Entity { get; set; }
        public int RequiredPostQuantity { get; set; }
        public TimeSpan TimeFrame { get; set; }
        public bool Active { get; set; }
    }
}
