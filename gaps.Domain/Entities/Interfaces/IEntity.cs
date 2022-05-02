﻿namespace gaps.Domain.Entities.Interfaces
{
    public interface IEntity<TKey> : IEntity
    {
        TKey Id { get; }
    }
    public interface IEntity
    {
        object[] GeyKeys();
    }
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}
