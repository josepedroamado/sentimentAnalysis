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

        public override string ToString()
        {
            string status = "Inactiva";
            if (Active)
            {
                status = "Activa";
            }
            TimeSpan timeFrame = new TimeSpan(TimeFrame);
            String toReturn = String.Format(
                "Entidad: " + Entity.Name
                + ", Cantidad de posts " + PhrasesType + ": " + RequiredPostQuantity 
                + " de tipo Autores en " + timeFrame.Days + " días "
                + timeFrame.Hours + " horas, Estado: " + status);
            return toReturn;
        }
    }
}
