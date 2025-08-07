using Ecommerce.Application.Implementions;
using Ecommerce.Application.Interface;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplicationInjection(this IServiceCollection services)
        {
            // Register your application services here
            // Example: services.AddScoped<IMyService, MyService>();
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}
