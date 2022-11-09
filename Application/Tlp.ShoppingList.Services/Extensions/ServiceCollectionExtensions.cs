using MediatR;
using Tlp.ShoppingList.Services.Abstracts;
using Tlp.ShoppingList.Services.Concretes;

namespace Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDataServices(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<ILookupService, LookupService>();
        services.AddScoped<ISystemParameterService, SystemParameterService>();
        services.AddScoped<ILookupTypeService, LookupTypeService>();

        var queriesAssembly = AppDomain.CurrentDomain.Load("Tlp.ShoppingList.Management.Queries");
        var commandsAssembly = AppDomain.CurrentDomain.Load("Tlp.ShoppingList.Management.Commands");
        services.AddMediatR(queriesAssembly, commandsAssembly);
        return services;
    }
}