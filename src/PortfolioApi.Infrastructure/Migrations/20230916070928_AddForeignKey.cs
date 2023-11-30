using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApi.Infrastructure.Migrations
{
    public partial class AddForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutUsers",
                table: "About",
                newName: "AboutMe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AboutMe",
                table: "About",
                newName: "AboutUsers");
        }
    }
}
