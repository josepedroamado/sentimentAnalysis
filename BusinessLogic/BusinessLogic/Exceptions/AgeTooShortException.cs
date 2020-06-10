using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class AgeTooShortException : Exception
    {


        public AgeTooShortException(int age)
            : base(String.Format("La Edad no puede ser menor a : " + age))
        {

        }




    }
}