using Domain.Entities;
using gaps.Domain.Entities.Interfaces;
using gaps.Infrastructure.Repositories.Base;
using Infrastructure;
using System;
using System.Threading.Tasks;

namespace gaps.Infrastructure.Repositories.General
{
    public class CustomerRepository : EfCoreRepository<ApplicationDbContext, Customer, Guid>, ICustomerRepository, IRepository<Customer>
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<Customer> TestRepository()
        {
            var customer = new Customer { Address = "", FirstName = "Prueba" };
            var prueba2 = await this.InsertAsync(customer);
            await Dispose();
            return prueba2;
        }
    }
}
