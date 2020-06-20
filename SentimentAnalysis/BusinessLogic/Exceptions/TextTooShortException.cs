using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class TextTooShortException : Exception
    {


        public TextTooShortException(int Length)
            : base(String.Format("The text cannot be Shorter than: " + Length))
        {

        }




    }
}