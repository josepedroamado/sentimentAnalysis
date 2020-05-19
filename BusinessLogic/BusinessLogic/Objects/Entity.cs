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

        public Entity(String aName)
        {
            AssignId();
            this.Name = aName;
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
    }
}
