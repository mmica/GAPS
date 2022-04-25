using System;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; protected set; }
        public virtual string UserName { get; private set; }

        public string FirstName { get; set; }
        public string SurName { get; set; }
        public virtual string PhoneNumber { get; private set; }
        public virtual string Email { get; private set; }

    }
}
