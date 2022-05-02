using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace gaps.Domain.Entities.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> TestRepository();
    }
}
