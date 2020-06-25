using System;

namespace BusinessLogic
{
    public class AuthorAlarm: Alarm
    {
        private const int MAX_QUANTITY = 1000;
        private const int MIN_QUANTITY = 1;

        public string PhrasesType { get; set; }
        
        public AuthorAlarm(Entity aEntity, int aRequiredPostQuantity, TimeSpan aTimeSpan, string aPhrasesType)
        {
            AlarmId = Guid.NewGuid();
            Entity = aEntity;
            SetRequiredQuantity(aRequiredPostQuantity);
            TimeFrame = aTimeSpan.Ticks;
            Active = false;
            PhrasesType = aPhrasesType;
        }

        public void SetRequiredQuantity(int aRequiredPostQuantity)
        {
            if (aRequiredPostQuantity < MIN_QUANTITY)
            {
                throw new QuantityTooLow(MIN_QUANTITY);
            }
            else if (aRequiredPostQuantity > MAX_QUANTITY)
            {
                throw new QuantityTooHigh(MAX_QUANTITY);
            }
            else
            {
                this.RequiredPostQuantity = aRequiredPostQuantity;
            }
        }
    }
}
