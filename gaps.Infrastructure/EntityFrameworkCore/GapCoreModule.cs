using Domain.Entities;
using gaps.Infrastructure.Repositories.General;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace gaps.Infrastructure.EntityFrameworkCore
{
    //Class created to put here all relationed with DI
    public static class GapCoreModule
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
            });
        }
    }
}
