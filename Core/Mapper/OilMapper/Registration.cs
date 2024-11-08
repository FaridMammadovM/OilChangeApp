using Application.Interfaces.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace OilMapper
{
    public static class Registration
    {
        public static void AddCustomMapper(this IServiceCollection services)
        {
            services.AddSingleton<ICostumMapper, CostumMapper>();
        }
    }
}
