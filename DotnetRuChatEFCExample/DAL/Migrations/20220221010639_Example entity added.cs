using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetRuChatEFCExample.DAL.Migrations
{
    public partial class Exampleentityadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExampleEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ExampleString = table.Column<string>(type: "text", nullable: false),
                    ExampleBool = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExampleEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExampleEntities");
        }
    }
}
