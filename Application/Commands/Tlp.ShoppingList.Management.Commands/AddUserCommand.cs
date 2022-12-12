using AutoMapper;
using MediatR;
using Tlp.ShoppingList.Application.Abstracts;
using Tlp.ShoppingList.Data.Request.Queries;
using Tlp.ShoppingList.Domain.Common;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Management.Commands
{
    public class AddUserCommand : IRequestHandler<AddUserRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public AddUserCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var repository = unitOfWork.GetRepository<User>();
            var existingUser = await repository.Get(f => f.Email == request.Data.EMail ||
                                                               f.UserName == request.Data.UserName,
                                                          cancellationToken);
            if (existingUser != null)
            {
                return false;
            }
            var entity = mapper.Map<User>(request.Data);
            entity.Password = request.Data.Password.CreateHash();
            repository.Insert(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}
