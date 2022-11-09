using AutoMapper;
using MediatR;
using Tlp.ShoppingList.Application.Abstracts;
using Tlp.ShoppingList.Data.Commands.Request;
using Tlp.ShoppingList.Domain.Common;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Management.Commands
{
    internal class RegisterUserCommand : IRequestHandler<RegisterUserRequest, bool>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public RegisterUserCommand(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<bool> Handle(RegisterUserRequest request, CancellationToken cancellationToken)
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
            entity.PasswordHash = Guid.NewGuid().ToString();
            entity.Password = (request.Data.Password + entity.PasswordHash).CreateHash();
            repository.Insert(entity);
            var result = await unitOfWork.SaveChanges(cancellationToken);
            return result > 0;
        }
    }
}
