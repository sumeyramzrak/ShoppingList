using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;

namespace Tlp.ShoppingList.Data.Request.Queries
{
    public class AddUserRequest : IRequest<bool>
    {
        public AddUserRequest(NewUserRequestDto data)
        {
            Data = data;
        }

        public NewUserRequestDto Data { get; }
    }
}
