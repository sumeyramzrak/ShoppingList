using Microsoft.EntityFrameworkCore;
using Tlp.ShoppingList.Domain.Entities.Main;
using Tlp.ShoppingList.Domain.Entities.User;

namespace Tlp.ShoppingList.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<List> ShoppingLists { get; set; }
        public DbSet<Lookup> LookUps { get; set; }
        public DbSet<LookupType> LookUpTypes { get; set; }
        public DbSet<SystemParameter> SystemParameters { get; set; }
    }
}