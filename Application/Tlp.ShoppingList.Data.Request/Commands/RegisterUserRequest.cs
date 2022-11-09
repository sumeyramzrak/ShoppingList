using MediatR;
using Tlp.ShoppingList.Data.Request.Contracts;

namespace Tlp.ShoppingList.Data.Commands.Request
{
    public class RegisterUserRequest : IRequest<bool>
    {
        public RegisterUserRequest(RegisterUserRequestDto data)
        {
            Data = data;
        }

        public RegisterUserRequestDto Data { get; }
    }
}
