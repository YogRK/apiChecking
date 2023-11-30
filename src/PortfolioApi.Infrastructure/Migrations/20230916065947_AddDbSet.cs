using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioApi.Infrastructure.Migrations;

  public partial class AddDbSet : Migration
  {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "About",
              columns: table => new
              {
                  Id = table.Column<int>(type: "int", nullable: false)
                      .Annotation("SqlServer:Identity", "1, 1"),
                  UserId = table.Column<int>(type: "int", nullable: false),
                  AboutUsers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                  ModifiedBy = table.Column<int>(type: "int", nullable: true),
                  CreatedBy = table.Column<int>(type: "int", nullable: true),
                  CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                  ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_About", x => x.Id);
              });
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "About");
      }
  }
