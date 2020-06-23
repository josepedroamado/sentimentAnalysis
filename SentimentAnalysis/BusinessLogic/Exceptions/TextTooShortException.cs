using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class TextTooShortException : Exception
    {
        public TextTooShortException(int min)
            : base(String.Format("El nombre no puede ser menor a " + min + " caracteres."))
        {

        }
    }
}