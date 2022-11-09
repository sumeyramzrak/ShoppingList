using MediatR;
using Tlp.ShoppingList.Application.Abstracts;
using Tlp.ShoppingList.Data.Queries.Requests;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Queries.Requests
{
    internal class GetUserListQuery:IRequestHandler<GetUserRequest,List<UserListDto>> //TRequest bir IRequest olmalı ve o IRequest de TResponse u barındırmalı
    {
        private readonly IUnitOfWork unitOfWork;
        public GetUserListQuery(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public Task<List<UserListDto>> Handle(GetUserRequest request,CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<User>();
            return repository.GetAll<UserListDto>(f => true, o => o.EMail, cancellationToken);
        }
    }
}