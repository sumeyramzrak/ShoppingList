using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tlp.ShoppingList.DataSeed
{
    public interface ITestSeeder
    {
        void Seed(DbContext dbContext);
    }
}
