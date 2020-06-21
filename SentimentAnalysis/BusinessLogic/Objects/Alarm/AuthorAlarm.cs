using System;

namespace BusinessLogic
{
    public class AuthorAlarm: Alarm
    {
        private string phrasesType;
        
        public AuthorAlarm(Entity aEntity, int aRequiredPostQuantity, TimeSpan aTimeSpan, string aPhrasesType)
        {
            AlarmId = Guid.NewGuid();
            Entity = aEntity;
            RequiredPostQuantity = aRequiredPostQuantity;
            TimeFrame = aTimeSpan.Ticks;
            Active = false;
            phrasesType = aPhrasesType;
        }

        public override string ToString()
        {
            string status = "Inactiva";
            if (Active)
            {
                status = "Activa";
            }

            String toReturn = String.Format(
                "Entidad: " + Entity.Name
                + ", Cantidad de posts " + phrasesType + ": " + RequiredPostQuantity 
                + " de tipo Autores en " + new TimeSpan(TimeFrame).Hours
                + " horas, Estado: " + status);
            return toReturn;
        }
    }
}
