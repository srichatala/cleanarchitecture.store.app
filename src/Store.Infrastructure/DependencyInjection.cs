using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Store.Application.Common.Interfaces;
using Store.Infrastructure.Data;

namespace Store.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StoreContext>(options =>
                   options.UseSqlServer(
                       configuration.GetConnectionString("DatabaseConnection")));
            services.AddScoped<IStoreContext>(provider => provider.GetService<StoreContext>());
            return services;
        }
    }
}
