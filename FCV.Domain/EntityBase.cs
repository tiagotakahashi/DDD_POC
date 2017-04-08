using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCV.Domain
{
    public class EntityBase
    {
        public int ID { get; set; }

        public override string ToString()
        {
            return $"{GetType()} {ID}";
        }

        public override bool Equals(object obj)
        {
            var otherEntity = obj as EntityBase;
            if (otherEntity == null) return false;
            return ID == otherEntity.ID;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public static bool operator ==(EntityBase a, EntityBase b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(EntityBase a, EntityBase b)
        {
            return !Equals(a, b);
        }
    }
}
