using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class TooYoungException : Exception
    {


        public TooYoungException(int age)
            : base(String.Format("La Edad no puede ser menor a : " + age))
        {

        }




    }
}