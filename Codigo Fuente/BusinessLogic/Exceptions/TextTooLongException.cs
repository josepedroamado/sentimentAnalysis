using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class TextTooLongException : Exception
    {
        public TextTooLongException(int max)
            : base(String.Format("El nombre no puede ser mayor a "+ max + " caracteres."))
        {
            
        }     
    }
}