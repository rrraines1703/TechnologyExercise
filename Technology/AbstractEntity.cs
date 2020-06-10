using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }

        public AbstractEntity(string value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value;
        }

        public override bool Equals(object obj)
        {
            return obj is AbstractEntity entity &&
                   Id == entity.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
