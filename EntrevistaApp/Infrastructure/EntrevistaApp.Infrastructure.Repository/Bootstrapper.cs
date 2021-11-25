using EntrevistaApp.Domain.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EntrevistaApp.Infrastructure.Repository
{
    public static class Bootstrapper
    {
        public static IServiceCollection AddBootstrapperApplication(this IServiceCollection services)
        {
            services.AddScoped<IQuestaoRepository, QuestaoRepository>();
            return services;
        }
    }
}