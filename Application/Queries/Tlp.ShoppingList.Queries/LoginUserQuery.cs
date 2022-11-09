using MediatR;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Spread.Data.Query.Requests;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Application.Abstracts;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Domain.Common;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Spread.Data.Management.Queries;

internal class LoginUserQuery : IRequestHandler<LoginUserRequest, LoginResultDto>
{
    private readonly IUnitOfWork unitOfWork;
    private readonly Settings.JwtConfiguration configuration;

    public LoginUserQuery(IUnitOfWork unitOfWork, IOptions<Settings> options)
    {
        this.unitOfWork = unitOfWork;
        configuration = options.Value.Jwt;
    }

    public async Task<LoginResultDto> Handle(LoginUserRequest request, CancellationToken cancellationToken)
    {
        var repository = unitOfWork.GetRepository<User>();
        var entity = await repository.Get(f => f.UserName == request.Data.UserName, cancellationToken);
        if (entity == null) //user boş ise null dönsün
        {
            return null;
        }
        var password = (request.Data.Password + entity.PasswordHash).CreateHash(); //güvenliği arttırmak adına password ve hashi birleştirip tekrar hash i alınarak parola oluşturuluyor.
        if (entity.Password != password) // user parolası mevycut değerle aynı değilse null dönsün.
        {
            return null;
        }

        var claims = new Dictionary<string, object>();
        claims.Add(ClaimTypes.NameIdentifier, entity.Id);
        claims.Add(ClaimTypes.GivenName, entity.UserName);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Expires = DateTime.Now.AddMinutes(configuration.ExpiresInMinutes),
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.Key)),
                                                        SecurityAlgorithms.HmacSha256Signature),
            Claims = claims,
            IssuedAt = DateTime.Now,
            NotBefore = DateTime.Now
        };

        var handler = new JwtSecurityTokenHandler();
        var token = handler.CreateToken(tokenDescriptor);
        var jwtToken = handler.WriteToken(token);
        return new LoginResultDto
        {
            Token = jwtToken,
            DisplayName = $"{entity.UserName} ({entity.Email})"
        };
    }
}
