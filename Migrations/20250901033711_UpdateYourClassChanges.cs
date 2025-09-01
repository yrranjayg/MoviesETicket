using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MoviesETicket.Migrations
{
    /// <inheritdoc />
    public partial class UpdateYourClassChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullNanme",
                table: "Producers",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Movies",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "FullNanme",
                table: "Actors",
                newName: "FullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Producers",
                newName: "FullNanme");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Movies",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Actors",
                newName: "FullNanme");
        }
    }
}
