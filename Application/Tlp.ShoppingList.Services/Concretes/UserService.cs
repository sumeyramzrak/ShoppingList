using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Queries.Requests;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Data.Request.Queries;
using Tlp.ShoppingList.Services.Abstracts;

namespace Tlp.ShoppingList.Services.Concretes
{
    internal class UserService : IUserService
    {
        private readonly IMediator mediator;

        public UserService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public Task<List<UserListDto>> GetUsers(CancellationToken cancellationToken)
        {
            return mediator.Send(new GetUserRequest(), cancellationToken);
        }
        public Task<bool> AddUser(NewUserRequestDto data, CancellationToken cancellationToken)
        {
            return mediator.Send(new AddUserRequest(data), cancellationToken);
        }

    }
}
