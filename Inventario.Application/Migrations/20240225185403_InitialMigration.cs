using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inventario.Application.Migrations;

public partial class InitialMigration : Migration {
    protected override void Up(MigrationBuilder migrationBuilder) {
        migrationBuilder.CreateTable(
            name: "Categories",
            columns: table => new {
                Id = table.Column<Guid>(type: "TEXT", nullable: false),
                Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                Active = table.Column<bool>(type: "INTEGER", nullable: false),
                CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                ModificationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table => {
                table.PrimaryKey("PK_Categories", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Providers",
            columns: table => new {
                Id = table.Column<Guid>(type: "TEXT", nullable: false),
                Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                Address = table.Column<string>(type: "TEXT", maxLength: 300, nullable: false),
                City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                Email = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                Active = table.Column<bool>(type: "INTEGER", nullable: false),
                CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                ModificationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table => {
                table.PrimaryKey("PK_Providers", x => x.Id);
            });

        migrationBuilder.CreateTable(
            name: "Products",
            columns: table => new {
                Id = table.Column<Guid>(type: "TEXT", nullable: false),
                Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                Stock = table.Column<int>(type: "INTEGER", nullable: false),
                MinStock = table.Column<int>(type: "INTEGER", nullable: false),
                CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                ProviderId = table.Column<int>(type: "INTEGER", nullable: false),
                CategoryId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                ProviderId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                Active = table.Column<bool>(type: "INTEGER", nullable: false),
                CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                ModificationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table => {
                table.PrimaryKey("PK_Products", x => x.Id);
                table.ForeignKey(
                    name: "FK_Products_Categories_CategoryId1",
                    column: x => x.CategoryId1,
                    principalTable: "Categories",
                    principalColumn: "Id");
                table.ForeignKey(
                    name: "FK_Products_Providers_ProviderId1",
                    column: x => x.ProviderId1,
                    principalTable: "Providers",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "Sales",
            columns: table => new {
                Id = table.Column<Guid>(type: "TEXT", nullable: false),
                ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                SalesDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                ProductId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                Active = table.Column<bool>(type: "INTEGER", nullable: false),
                CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                ModificationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table => {
                table.PrimaryKey("PK_Sales", x => x.Id);
                table.ForeignKey(
                    name: "FK_Sales_Products_ProductId1",
                    column: x => x.ProductId1,
                    principalTable: "Products",
                    principalColumn: "Id");
            });

        migrationBuilder.CreateTable(
            name: "Stocks",
            columns: table => new {
                Id = table.Column<Guid>(type: "TEXT", nullable: false),
                ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                IncomingQuantity = table.Column<int>(type: "INTEGER", nullable: false),
                Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                UserId = table.Column<int>(type: "INTEGER", nullable: false),
                IncomingDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                ProductId1 = table.Column<Guid>(type: "TEXT", nullable: true),
                Active = table.Column<bool>(type: "INTEGER", nullable: false),
                CreationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                ModificationDate = table.Column<DateTime>(type: "TEXT", nullable: false)
            },
            constraints: table => {
                table.PrimaryKey("PK_Stocks", x => x.Id);
                table.ForeignKey(
                    name: "FK_Stocks_Products_ProductId1",
                    column: x => x.ProductId1,
                    principalTable: "Products",
                    principalColumn: "Id");
            });

        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "Active", "CreationDate", "Description", "ModificationDate", "Name" },
            values: new object[] { new Guid("1ddcf94e-df37-4dae-ac0d-bacef34ce383"), true, new DateTime(2024, 2, 25, 12, 54, 3, 334, DateTimeKind.Local).AddTicks(3537), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mouse" });

        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "Active", "CreationDate", "Description", "ModificationDate", "Name" },
            values: new object[] { new Guid("5fa22043-9d98-413a-91f7-6c012cf98a2c"), true, new DateTime(2024, 2, 25, 12, 54, 3, 334, DateTimeKind.Local).AddTicks(3518), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Memoria USB" });

        migrationBuilder.InsertData(
            table: "Categories",
            columns: new[] { "Id", "Active", "CreationDate", "Description", "ModificationDate", "Name" },
            values: new object[] { new Guid("ad1039b0-19dc-4ee0-a709-84d2db7e8f8a"), true, new DateTime(2024, 2, 25, 12, 54, 3, 334, DateTimeKind.Local).AddTicks(3535), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Auriculares" });

        migrationBuilder.CreateIndex(
            name: "IX_Products_CategoryId1",
            table: "Products",
            column: "CategoryId1");

        migrationBuilder.CreateIndex(
            name: "IX_Products_ProviderId1",
            table: "Products",
            column: "ProviderId1");

        migrationBuilder.CreateIndex(
            name: "IX_Sales_ProductId1",
            table: "Sales",
            column: "ProductId1");

        migrationBuilder.CreateIndex(
            name: "IX_Stocks_ProductId1",
            table: "Stocks",
            column: "ProductId1");
    }

    protected override void Down(MigrationBuilder migrationBuilder) {
        migrationBuilder.DropTable(
            name: "Sales");

        migrationBuilder.DropTable(
            name: "Stocks");

        migrationBuilder.DropTable(
            name: "Products");

        migrationBuilder.DropTable(
            name: "Categories");

        migrationBuilder.DropTable(
            name: "Providers");
    }
}