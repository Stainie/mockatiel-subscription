using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0075fa58-9e6c-426f-a06a-7dfccfee75f7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0d4b434b-9a72-41e0-b86a-6d3fc4538890");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "493ff633-24a4-4604-b3c8-c37b13ebcad5");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6d8431a7-7fae-4195-b767-4349422a3ca9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7071b9cd-7119-4572-ad9b-a85f173e9c7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "985b8626-b1f8-4279-b0ab-646719e99145");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a327435a-ba66-43c0-852a-6e19761203fd");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bd4cba41-2f7b-4d62-b868-19adf2c9c586");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c1d1fc84-23a6-434f-9cbd-e72c31ec9063");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ca093598-43aa-4f56-94b4-d60d73b41769");

            migrationBuilder.AlterColumn<long>(
                name: "Price",
                table: "Products",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "TEXT");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { "09a9bb7a-5c5a-499e-8b1f-303449e86f44", "Description for product 3", "https://picsum.photos/seed/3/200/300", "Product 3", 30L },
                    { "2de2864d-4cc4-48d0-b21d-89bbac5ab2a6", "Description for product 9", "https://picsum.photos/seed/9/200/300", "Product 9", 90L },
                    { "402fbb85-3461-4e67-bdd6-bcef2b5766a2", "Description for product 4", "https://picsum.photos/seed/4/200/300", "Product 4", 40L },
                    { "444831a2-b45c-4329-9995-dd646d8b4bf9", "Description for product 1", "https://picsum.photos/seed/1/200/300", "Product 1", 10L },
                    { "4fba4918-9e8b-47ff-bcc4-4a10792c0008", "Description for product 7", "https://picsum.photos/seed/7/200/300", "Product 7", 70L },
                    { "5bd416be-f365-438a-8ffa-4ecd37b07ba7", "Description for product 5", "https://picsum.photos/seed/5/200/300", "Product 5", 50L },
                    { "7e503df6-9e02-49a2-91ed-e5609f3e4b60", "Description for product 6", "https://picsum.photos/seed/6/200/300", "Product 6", 60L },
                    { "8c817c45-95fd-410d-92b4-5ad162df0aa4", "Description for product 8", "https://picsum.photos/seed/8/200/300", "Product 8", 80L },
                    { "c82586ad-ae90-4885-a3ae-3713cf95bb2c", "Description for product 10", "https://picsum.photos/seed/10/200/300", "Product 10", 100L },
                    { "e1156c28-92ef-4e4f-b56e-ae79bed24952", "Description for product 2", "https://picsum.photos/seed/2/200/300", "Product 2", 20L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "09a9bb7a-5c5a-499e-8b1f-303449e86f44");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2de2864d-4cc4-48d0-b21d-89bbac5ab2a6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "402fbb85-3461-4e67-bdd6-bcef2b5766a2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "444831a2-b45c-4329-9995-dd646d8b4bf9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4fba4918-9e8b-47ff-bcc4-4a10792c0008");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "5bd416be-f365-438a-8ffa-4ecd37b07ba7");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7e503df6-9e02-49a2-91ed-e5609f3e4b60");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8c817c45-95fd-410d-92b4-5ad162df0aa4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c82586ad-ae90-4885-a3ae-3713cf95bb2c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e1156c28-92ef-4e4f-b56e-ae79bed24952");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

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
    }
}
