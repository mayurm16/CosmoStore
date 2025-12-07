using CosmoStore.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CosmoStore.Infra
{
    public sealed class InfrastructureInjector
    {
        public static IServiceCollection AddInfraStructure(IServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(ConnectionString));
            return services;
        }
    }
}
