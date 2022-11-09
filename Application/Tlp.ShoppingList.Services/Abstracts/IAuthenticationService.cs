using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;

namespace Tlp.ShoppingList.Services.Abstracts
{
    public interface IAuthenticationService
    {
        Task<bool> RegisterUser(RegisterUserRequestDto data, CancellationToken cancellationToken);
        Task<LoginResultDto> LoginUser(LoginUserRequestDto data, CancellationToken cancellationToken);
    }
}
