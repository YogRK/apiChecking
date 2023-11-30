using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApi.Infrastructure.Migrations
{
    public partial class gh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_About_Users_UsersId",
                table: "About");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "About");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "About",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_About_Users_UsersId",
                table: "About",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_About_Users_UsersId",
                table: "About");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "About",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "About",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_About_Users_UsersId",
                table: "About",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
