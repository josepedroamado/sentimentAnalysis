using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class TextTooLongException : Exception
    {


        public TextTooLongException(int mAX_BODY_TEXT)
            : base(String.Format("The text cannot be bigger than: "+ mAX_BODY_TEXT))
        {
            
        }



       
    }
}