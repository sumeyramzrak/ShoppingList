using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tlp.ShoppingList.Persistence.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.MigrateUsers();
            migrationBuilder.MigrateLookups();
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
