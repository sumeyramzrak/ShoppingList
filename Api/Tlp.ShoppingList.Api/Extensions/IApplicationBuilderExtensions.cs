using Tlp.ShoppingList.Api.Middleware;

namespace Microsoft.AspNetCore.Builder; //useAuthorization ın namespace i

public static class IApplicationBuilderExtensions
{
    public static void UseClaims(this IApplicationBuilder app)
    {
        app.UseMiddleware<ClaimSetupMiddleware>();
    }
}
