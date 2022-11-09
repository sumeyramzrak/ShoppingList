using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tlp.ShoppingList.Domain.Entities.Main;

namespace Tlp.ShoppingList.DataSeed.TestSeeder
{
    public class LookUpTypeSeeder : ITestSeeder
    {
        public void Seed(DbContext dbContext)
        {
            dbContext.Set<LookupType>().AddRange(
                new LookupType
                {
                    Id = new Guid("C868A137-EFAD-446A-8A62-211574F51241"),
                    Name = "Test LookupType",
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                    IsActive = true,
                },
                new LookupType
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000005"),
                    Name = "Test LookupType2",
                    CreatedAt = DateTime.UtcNow,
                    ModifiedAt = DateTime.UtcNow,
                    IsActive = true,
                });

        }

    }
}
