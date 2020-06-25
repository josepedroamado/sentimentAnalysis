using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    [Serializable]
    public class QuantityTooLow: Exception
    {
        public QuantityTooLow(int min)
            : base(String.Format("La cantidad requerida de publicaciones no puede ser menor a " + min + "."))
        {

        }
    }
}