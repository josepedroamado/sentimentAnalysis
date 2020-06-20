using BusinessLogic;
using System;

namespace DataAccess
{
    public class AlarmDto
    {
        public Guid AlarmDtoId { get; set; }

        public EntityDto Entity { get; set; }

        public int RequiredPostQuantity { get; set; }

        public TimeSpan TimeFrame { get; set; }

        public bool Active { get; set; }
    }
}