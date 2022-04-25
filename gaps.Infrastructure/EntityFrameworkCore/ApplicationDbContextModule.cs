using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ApplicationDbContextModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var prueba = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(                
                opt => opt.UseSqlServer("name=ConnectionStrings:DefaultConnection"));

            return services;
        }
    }
}
