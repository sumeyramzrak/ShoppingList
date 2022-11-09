using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain.Entities.Main;

namespace Tlp.ShoppingList.DataSeed.TestSeeder
{
    public class SystemParameterSeeder : ITestSeeder
    {
        public void Seed(DbContext dbContext)
        {
            dbContext.Set<SystemParameter>().AddRange(
                new SystemParameter
                {
                    Key = "test",
                    Value = "test",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true
                },
                new SystemParameter
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000001"),
                    Key = "test2",
                    Value = "test2",
                    CreatedAt = DateTime.Now,
                    ModifiedAt = DateTime.Now,
                    IsActive = true
                });

        }
    }

}
