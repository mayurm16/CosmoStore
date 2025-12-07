using CosmoStore.Infra.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmoStore.Infra
{
    public sealed class InfrastructureInjector
    {
        public static IServiceCollection AddInfraStructure(IServiceCollection services, string ConnectionString)
        {
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(ConnectionString));
        }
    }
}
