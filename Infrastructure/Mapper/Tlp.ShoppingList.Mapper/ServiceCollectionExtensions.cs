using Tlp.ShoppingList.Mapper.Profiles;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(config =>
        {
            config.AddProfile<ProfileProfile>();
            config.AddProfile<MainProfile>();
        });
        return services;
    }
}