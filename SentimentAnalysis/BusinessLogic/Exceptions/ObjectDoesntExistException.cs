using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class ObjectDoesntExistException : Exception
    {


        public ObjectDoesntExistException(string type)
            : base(String.Format("Este/a " + type + " no esta registrado/a"))
        {

        }




    }
}