using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mvc.Application.Abstraction;
using Mvc.Application.Services;
using Mvc.Infrastructure.DataAcces;
using Mvc.Infrastructure.Services;

namespace Mvc.Infrastructure
{
    public static class RegisteriService
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IApplicationDbContext,InventoryDbContext,>(dbContextOption =>
            dbContextOption.UseNpgsql(configuration.GetConnectionString("DbConnection")));

            services.AddSingleton<ITelegramService, TelegramService>();
            return services;
        }
    }
}
