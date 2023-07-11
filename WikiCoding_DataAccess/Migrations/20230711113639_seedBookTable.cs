using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WikiCoding_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "ISBN", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "1100001584279", 12.98m, "The new tale" },
                    { 2, "01561216803", 34.23m, "once upon a time" },
                    { 3, "01725797413", 32.45m, "Making a new faith" },
                    { 4, "10892163360", 22.41m, "Big Star" },
                    { 5, "9877654", 11.21m, "B&H" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
