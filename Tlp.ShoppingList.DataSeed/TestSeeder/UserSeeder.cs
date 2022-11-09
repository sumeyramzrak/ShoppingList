using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.DataSeed.TestSeeder
{
    public class UserSeeder : ITestSeeder
    {
        public void Seed(DbContext dbContext)
        {
            dbContext.Set<User>().AddRange(
                new User
                {
                    UserName = "test1",
                    Email = "test1@shoppingList.com",
                    Password = "1234",
                    PasswordHash = "2",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true
                },
                new User
                {
                    UserName = "test2",
                    Email = "test2@shoppingList.com",
                    Password = "1234",
                    PasswordHash = "2",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true
                });
              
        }
    }

}
