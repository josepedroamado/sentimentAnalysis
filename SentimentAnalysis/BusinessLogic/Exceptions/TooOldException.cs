using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class TooOldException : Exception
    {


        public TooOldException(int age)
            : base(String.Format("La Edad no puede ser mayor a : " + age))
        {

        }




    }
}