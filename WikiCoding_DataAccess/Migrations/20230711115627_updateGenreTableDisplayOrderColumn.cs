using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WikiCoding_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateGenreTableDisplayOrderColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "tb_genres");

            migrationBuilder.RenameColumn(
                name: "DisplayOrder",
                table: "tb_genres",
                newName: "Display Order");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_genres",
                table: "tb_genres",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_genres",
                table: "tb_genres");

            migrationBuilder.RenameTable(
                name: "tb_genres",
                newName: "Genres");

            migrationBuilder.RenameColumn(
                name: "Display Order",
                table: "Genres",
                newName: "DisplayOrder");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "Id");
        }
    }
}
