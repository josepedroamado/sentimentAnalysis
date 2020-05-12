using System;
using System.Runtime.Serialization;

namespace BusinessLogic
{
    [Serializable]
    public class EntityDoesntExistException : Exception
    {


        public EntityDoesntExistException()
            : base(String.Format("That Entity isn't registered"))
        {

        }




    }
}