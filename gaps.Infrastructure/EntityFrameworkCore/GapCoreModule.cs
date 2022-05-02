using gaps.Domain.Entities.Interfaces;
using gaps.Infrastructure.Repositories.General;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace gaps.Infrastructure.EntityFrameworkCore
{
    //Class created to put here all relationed with DI
    public static class GapCoreModule
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
           
        }
    }
}
