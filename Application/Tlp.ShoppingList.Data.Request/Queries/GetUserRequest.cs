using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Data.Queries.Requests
{
    //mediator yükle
    public class GetUserRequest : IRequest<List<UserListDto>> //IRequest mediatordan geliyor.
    {
    }
}
