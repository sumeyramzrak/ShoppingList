using MediatR;
using Spread.Data.Query.Requests;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Services.Abstracts;

namespace Tlp.ShoppingList.Services.Concretes
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IMediator mediator;

        public AuthenticationService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<LoginResultDto> LoginUser(LoginUserRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new LoginUserRequest(data), cancellationToken);
        }
    }
}
