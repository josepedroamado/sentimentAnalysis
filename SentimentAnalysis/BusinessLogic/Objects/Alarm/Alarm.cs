using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class Alarm
    {
        public Guid AlarmId { get; set; }

        public Entity Entity { get; set; }

        public int RequiredPostQuantity { get; set; }

        public long TimeFrame { get; set; }

        public bool Active { get; set; }

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
        public override string ToString()
        {
            string status = "Inactiva";
            if(Active)
            {
                status = "Activa";
            }
            string tipo = "Positiva";
            if(this.GetType().Name == "NegativeAlarm")
            {
                tipo = "Negativa";
            }
            TimeSpan timeFrame = new TimeSpan(TimeFrame);
            String toReturn = String.Format(
                "Entidad: " + Entity.Name
                + ", Cantidad de posts: " 
                + RequiredPostQuantity + " de tipo " + tipo 
                + " en " + timeFrame.Days + " días " 
                + timeFrame.Hours + " horas, Estado: " + status);
            return toReturn;
        }
    }
}
