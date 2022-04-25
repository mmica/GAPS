using System;

namespace Domain.Entities.Auditing
{
    public abstract class FullAuditedAggregateRoot<TKey> : AuditedAggregateRoot<TKey>
    {

        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? DeletionTime { get; set; }
        public virtual Guid? DeleterId { get; set; }

        protected FullAuditedAggregateRoot(TKey id) : base(id)
        {
        }
        public FullAuditedAggregateRoot()
        {
        }
    }
}
