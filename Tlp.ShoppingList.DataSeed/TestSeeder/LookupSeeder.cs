using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain.Entities.Main;

namespace Tlp.ShoppingList.DataSeed.TestSeeder
{

    public class LookUpSeeder : ITestSeeder
    {
        public void Seed(DbContext dbContext)
        {
            dbContext.Set<Lookup>().AddRange(
                new Lookup
                {
                    Id = new Guid("EC534A08-824C-4F56-9E7A-F0E4C235C3E6"),
                    Name = "Test Lookup",
                    TypeId = ConstantIds.LookupType.CategoryId,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                    IsActive = true,
                },
                new Lookup
                {
                    Id = new Guid("BE7B98C3-DBB4-449B-8EAE-F23E739321EE"),
                    Name = "Test Lookup2",
                    TypeId = ConstantIds.LookupType.CategoryId,
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                    IsActive = true,
                });
        }

    }
}
