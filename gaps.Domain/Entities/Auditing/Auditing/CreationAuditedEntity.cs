using System;

namespace Domain.Entities.Auditing
{
    public abstract class CreationAuditedEntity<TKey> : Entity<TKey>
    {
        protected CreationAuditedEntity(TKey id) : base(id)
        {
        }
        protected CreationAuditedEntity()
        {
        }
        public virtual DateTime CreationTime { get; protected set; }
        public virtual Guid? CreatorId { get; protected set; }

    }
}
