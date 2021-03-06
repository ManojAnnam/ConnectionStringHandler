﻿using ConnectionStringHandler.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectionStringHandler.Business
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection RegisterBusinessDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.RegisterRepositoryDependencies(configuration);
           // services.AddDbContext()
            return services;
        }
    }
}
