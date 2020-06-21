using System;

namespace BusinessLogic
{
    public class AuthorAlarm: Alarm
    {
        public string PhrasesType { get; set; }
        
        public AuthorAlarm(Entity aEntity, int aRequiredPostQuantity, TimeSpan aTimeSpan, string aPhrasesType)
        {
            AlarmId = Guid.NewGuid();
            Entity = aEntity;
            RequiredPostQuantity = aRequiredPostQuantity;
            TimeFrame = aTimeSpan.Ticks;
            Active = false;
            PhrasesType = aPhrasesType;
        }
    }
}
