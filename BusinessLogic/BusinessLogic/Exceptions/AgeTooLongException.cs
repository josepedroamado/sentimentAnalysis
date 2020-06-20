using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class AgeTooLongException : Exception
    {


        public AgeTooLongException(int age)
            : base(String.Format("La Edad no puede ser mayor a : " + age))
        {

        }




    }
}