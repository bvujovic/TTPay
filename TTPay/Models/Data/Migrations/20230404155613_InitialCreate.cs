using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TTPay.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Susreti",
                columns: table => new
                {
                    SusretId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Datum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BojanPotrosio = table.Column<int>(type: "INTEGER", nullable: false),
                    BojanPlatio = table.Column<int>(type: "INTEGER", nullable: false),
                    ZecPotrosio = table.Column<int>(type: "INTEGER", nullable: false),
                    ZecPlatio = table.Column<int>(type: "INTEGER", nullable: false),
                    ManicPotrosio = table.Column<int>(type: "INTEGER", nullable: false),
                    ManicPlatio = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Susreti", x => x.SusretId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Susreti");
        }
    }
}
