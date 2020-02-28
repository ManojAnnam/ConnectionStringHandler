using ConnectionStringHandler.Business;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectionStringHandler.API
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterApiDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterBusinessDependencies(configuration);
            return services;
        }
    }
}
