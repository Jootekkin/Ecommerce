using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure
{
    public static class InfrastructureDependencyInjection
    {
        public static IServiceCollection AddInfrastructureInjection(this IServiceCollection services)
        {
            // Register your infrastructure services here
            // Example: services.AddScoped<IMyService, MyService>();
            return services;
        }
    }
}
