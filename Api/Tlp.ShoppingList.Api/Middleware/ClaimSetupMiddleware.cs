using System.Security.Claims;
using Tlp.ShoppingList.Domain.Common;

namespace Tlp.ShoppingList.Api.Middleware
{
    internal class ClaimSetupMiddleware
    {
        private readonly RequestDelegate next;

        public ClaimSetupMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IClaims claims)
        {
            if (httpContext.User.Identity.IsAuthenticated) // httpcontextteki user ın ıdentity si Authenticated mı?
            {
                claims.IsAuthenticated = true;
                claims.CurrentUser.Id = Guid.Parse(httpContext.User.Claims.First(f => f.Type == ClaimTypes.NameIdentifier).Value); //ıd guid olduğundan
            }
            await next(httpContext);
        }
    }
}
