using Tlp.ShoppingList.DataSeed;

namespace Microsoft.EntityFrameworkCore.Migrations
{
    public static class MigrationBuilderExtensions
    {
        public static void MigrateUsers(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Users",//tablo adı
                                        new string[]//kolonlar
                                        {
                                        "Id", "UserName", "EMail", "Password", "PasswordHash", "VerificationId", "IsBlocked", "IsActive", "IsDeleted", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy"
                                        },
                                        new object[,]//eklenecek veriler
                                        {
                                        //123.
                                        { ConstantIds.User.AdminId, "admin", "admin@shoppingList.com", "702890088273b69964ada4175d78e184d1bd695daf406e3dec07a25e5b631823", "AdminHashValue!", null, false, true, false, DateTime.Now, null, DateTime.Now, null },
                                        },
                                        schema: "User");
        }

        public static void MigrateLookups(this MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("LookupTypes",
                                        new string[]
                                        {
                                        "Id", "Name", "IsActive", "IsDeleted", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy"
                                        },
                                        new object[,]
                                        {
                                        {  ConstantIds.LookupType.CategoryId, "Kategori", true, false, DateTime.Now, null, DateTime.Now, null },
                                        },
                                        schema: "Main");

            var azId = Guid.NewGuid();

            migrationBuilder.InsertData("Lookups",
                                        new string[]
                                        {
                                        "Id", "Name", "TypeId", "ParentId", "IsActive", "IsDeleted", "CreatedAt", "CreatedBy", "ModifiedAt", "ModifiedBy"
                                        },
                                        new object[,]
                                        {
                                        {  ConstantIds.Lookup.Okul, "Okul", ConstantIds.LookupType.CategoryId, null, true, false, DateTime.Now, null, DateTime.Now, null },
                                      
                                        { ConstantIds.Lookup.Market, "Market", ConstantIds.LookupType.CategoryId, ConstantIds.Lookup.Market, true, false, DateTime.Now, null, DateTime.Now, null },

                                        },
                                        schema: "Main");
        }
    }   
}