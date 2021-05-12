using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess
{
    public static class Configure
    {
        public static void AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
        }
    }
}