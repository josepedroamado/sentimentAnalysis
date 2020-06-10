using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    internal class AgeTooLongException : Exception
    {


        public AgeTooLongException(int age)
            : base(String.Format("La Edad no puede ser mayor a : " + age))
        {

        }




    }
}