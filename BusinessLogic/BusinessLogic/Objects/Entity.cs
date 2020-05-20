using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Entity
    {
        public static int NextId = 1;

        public int EntityId { get; set; }

        public string Name { get; set; }

        private const int MAX_BODY_TEXT = 100;

        private const int MIN_BODY_TEXT = 2;

        public Entity(String aName)
        {
            AssignId();
            SetName(aName);
        }

        public override bool Equals(object obj)
        {
            Entity entity = obj as Entity;
            if (entity != null) return this.EntityId == entity.EntityId;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.EntityId.GetHashCode();
        }

        public int GetNextId()
        {
            return NextId;
        }

        private void AssignId()
        {
            this.EntityId = NextId;
            NextId++;
        }
        public void SetName(String aName)
        {
            IsNameCorrect(aName);
            this.Name = aName;
        }
        public void IsNameCorrect(String AName)
        {
            IsNameTooLong(AName);
            IsNameTooShortOrEmpty(AName);
        }
        private void IsNameTooLong(String aName)
        {
            if (aName.Length > MAX_BODY_TEXT)
            {
                throw new TextTooLongException(MAX_BODY_TEXT);
            }
        }
        private void IsNameTooShortOrEmpty(String aName)
        {
            if (aName.Length <= MIN_BODY_TEXT)
            {
                throw new TextTooShortException(MIN_BODY_TEXT);
            }
        }
    }
}
