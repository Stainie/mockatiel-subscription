using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { "0075fa58-9e6c-426f-a06a-7dfccfee75f7", "Description for product 2", "https://picsum.photos/seed/2/200/300", "Product 2", 20m },
                    { "0d4b434b-9a72-41e0-b86a-6d3fc4538890", "Description for product 10", "https://picsum.photos/seed/10/200/300", "Product 10", 100m },
                    { "493ff633-24a4-4604-b3c8-c37b13ebcad5", "Description for product 4", "https://picsum.photos/seed/4/200/300", "Product 4", 40m },
                    { "6d8431a7-7fae-4195-b767-4349422a3ca9", "Description for product 3", "https://picsum.photos/seed/3/200/300", "Product 3", 30m },
                    { "7071b9cd-7119-4572-ad9b-a85f173e9c7d", "Description for product 5", "https://picsum.photos/seed/5/200/300", "Product 5", 50m },
                    { "985b8626-b1f8-4279-b0ab-646719e99145", "Description for product 8", "https://picsum.photos/seed/8/200/300", "Product 8", 80m },
                    { "a327435a-ba66-43c0-852a-6e19761203fd", "Description for product 6", "https://picsum.photos/seed/6/200/300", "Product 6", 60m },
                    { "bd4cba41-2f7b-4d62-b868-19adf2c9c586", "Description for product 9", "https://picsum.photos/seed/9/200/300", "Product 9", 90m },
                    { "c1d1fc84-23a6-434f-9cbd-e72c31ec9063", "Description for product 7", "https://picsum.photos/seed/7/200/300", "Product 7", 70m },
                    { "ca093598-43aa-4f56-94b4-d60d73b41769", "Description for product 1", "https://picsum.photos/seed/1/200/300", "Product 1", 10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
