using System;

namespace Domain.Entities.Auditing
{
    public abstract class AuditedAggregateRoot<TKey> : CreationAuditedEntity<TKey>
    {
        public virtual DateTime? LastModificationTime { get; set; }
        public virtual Guid? LastModifierId { get; set; }
        protected AuditedAggregateRoot(TKey id) : base(id)
        {
        }
        public AuditedAggregateRoot()
        {
        }

    }
}
