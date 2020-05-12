using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class EntityAlreadyExistsException : Exception
    {


        public EntityAlreadyExistsException()
            : base(String.Format("That Entity is already registered"))
        {

        }




    }
}