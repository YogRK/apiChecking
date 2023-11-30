using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApi.Infrastructure.Migrations
{
    public partial class AddForeignK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsersId",
                table: "About",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_About_UsersId",
                table: "About",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_About_Users_UsersId",
                table: "About",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_About_Users_UsersId",
                table: "About");

            migrationBuilder.DropIndex(
                name: "IX_About_UsersId",
                table: "About");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "About");
        }
    }
}
