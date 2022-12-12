using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Data.Request.Contracts;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Mapper.Profiles
{
    public class ProfileProfile : Profile
    {
        public ProfileProfile()
        {
            CreateMap<User, UserListDto>();
            CreateMap<NewUserRequestDto, User>();
        }
    }
}
