using Domain.Entities.Auditing;
using System;

namespace Domain.Entities
{
    public class Customer : FullAuditedAggregateRoot<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Observation { get; set; }

        public Customer()
        {

        }
        public Customer(Guid id) : base(id)
        {

        }

        public override object[] GeyKeys()
        {
            throw new NotImplementedException();
        }
    }
}
