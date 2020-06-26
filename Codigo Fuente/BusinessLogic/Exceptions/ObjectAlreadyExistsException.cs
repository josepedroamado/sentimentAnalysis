using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class ObjectAlreadyExistsException : Exception
    {


        public ObjectAlreadyExistsException(string type)
            : base(String.Format("Este/a " + type + " ya esta registrado/a"))
        {

        }




    }
}