using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tlp.ShoppingList.DataSeed;

namespace Tlp.ShoppingList.Tests.Common
{
    public class TlpApplicationFactory : WebApplicationFactory<Program>
    {
        private IServiceProvider serviceProvider;

        public TlpApplicationFactory()
        {
            Client = base.CreateClient();
        }

        public HttpClient Client { get; set; }

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.UseEnvironment("Test");
            builder.ConfigureServices(services =>
            {
                var baseSeeder = typeof(ITestSeeder);
                var seeders = AppDomain.CurrentDomain.GetAssemblies()
                                                     .SelectMany(x => x.GetTypes())
                                                     .Where(t => baseSeeder.IsAssignableFrom(t) && t.IsClass);

                serviceProvider = services.BuildServiceProvider();
                using (var scope = serviceProvider.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetService<DbContext>();
                    dbContext.Database.EnsureDeleted();// test için oluşturulan database hata vb sebeplerden silinmemişse silinsin

                    dbContext.Database.Migrate();

                    foreach (var seeder in seeders)
                    {
                        var testSeeder = (ITestSeeder)Activator.CreateInstance(seeder);
                        testSeeder.Seed(dbContext);
                    }
                    dbContext.SaveChanges();
                }
            });
        }

        internal void Clean()
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetService<DbContext>();
                dbContext.Database.EnsureDeleted();
            }
        }

        protected override TestServer CreateServer(IWebHostBuilder builder)
        {
            return base.CreateServer(builder);
        }
    }
}
