using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;

namespace Spread.Data.Query.Requests;

public class LoginUserRequest : IRequest<LoginResultDto>
{
    public LoginUserRequest(LoginUserRequestDto data)
    {
        Data = data;
    }

    public LoginUserRequestDto Data { get; }
}

