using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public abstract class Entity<TKey> : Entity
    {
        protected Entity() { }
        protected Entity(TKey id)
        {
            Id = id;
        }
        public virtual TKey Id { get; protected set; }
        public override string ToString()
        {
            return $"[ENTITY: {GetType().Name}] Id = {Id}";
        }
        public override object[] GetKeys()
        {
            return new object[1]
            {
                Id
            };
        }
    }
    public abstract class Entity
    {
        public abstract object[] GetKeys();
       
    }
}
