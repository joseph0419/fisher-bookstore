using Microsoft.EntityFrameworkCore.Migrations;

namespace Fisher.Bookstore.Api.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publicationDate",
                table: "Books",
                newName: "publishDate");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Books",
                newName: "Publisher");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "publishDate",
                table: "Books",
                newName: "publicationDate");

            migrationBuilder.RenameColumn(
                name: "Publisher",
                table: "Books",
                newName: "Author");
        }
    }
}
