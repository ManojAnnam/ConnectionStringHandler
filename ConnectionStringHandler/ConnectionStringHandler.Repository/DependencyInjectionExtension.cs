using ConnectionStringHandler.Repository.DBModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringHandler.Repository
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterRepositoryDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ConnectionStringHadlerContext>(o => o.UseSqlServer(configuration["connectionStrings:ConnectionStringHandlerDBConnectionString"]));         
            return services;
        }
    }
}
