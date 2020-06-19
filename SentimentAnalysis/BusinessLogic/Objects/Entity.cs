using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Entity
    {
        private const int MAX_BODY_TEXT = 100;
        private const int MIN_BODY_TEXT = 2;

        public Guid EntityId { get; set; }
        public string Name { get; set; }       

        public Entity(String aName)
        {
            EntityId = Guid.NewGuid();
            SetName(aName);
        }

        public void SetName(String aName)
        {
            IsNameCorrect(aName);
            this.Name = aName;
        }

        public void IsNameCorrect(String aName)
        {
            IsNameTooLong(aName);
            IsNameTooShortOrEmpty(aName);
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
    }
}
