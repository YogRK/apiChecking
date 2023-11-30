using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApi.Infrastructure.Migrations;

  public partial class ModifyUserColumn : Migration
  {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.RenameColumn(
              name: "LasttName",
              table: "Users",
              newName: "LastName");
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.RenameColumn(
              name: "LastName",
              table: "Users",
              newName: "LasttName");
      }
  }
