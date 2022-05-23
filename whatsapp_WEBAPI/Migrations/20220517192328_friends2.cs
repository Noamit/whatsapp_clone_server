using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class friends2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Last",
                table: "Friend",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Lastdate",
                table: "Friend",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Last",
                table: "Friend");

            migrationBuilder.DropColumn(
                name: "Lastdate",
                table: "Friend");
        }
    }
}
