using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Services.Abstracts
{
    public interface IUserService
    {
        Task<List<UserListDto>> GetUsers(CancellationToken cancellationToken);
    }
}
