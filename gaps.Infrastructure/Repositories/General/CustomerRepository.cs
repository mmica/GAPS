using Domain.Entities;
using gaps.Infrastructure.Repositories.Base;
using Infrastructure;
using System;

namespace gaps.Infrastructure.Repositories.General
{
    public class CustomerRepository : EfCoreRepository<ApplicationDbContext, Customer, Guid>
    {
        public CustomerRepository(ApplicationDbContext dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
