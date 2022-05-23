using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class secondInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Friend_FriendRealId",
                table: "Message");

            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "FriendRealId",
                table: "Message",
                newName: "ContactRealId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_FriendRealId",
                table: "Message",
                newName: "IX_Message_ContactRealId");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Contact",
                newName: "Server");

            migrationBuilder.RenameColumn(
                name: "User",
                table: "Contact",
                newName: "Last");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "RealId",
                table: "Contact",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "FriendOf",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Lastdate",
                table: "Contact",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "RealId");

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    user = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Contact_ContactRealId",
                table: "Message",
                column: "ContactRealId",
                principalTable: "Contact",
                principalColumn: "RealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Contact_ContactRealId",
                table: "Message");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "RealId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "FriendOf",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "Lastdate",
                table: "Contact");

            migrationBuilder.RenameColumn(
                name: "ContactRealId",
                table: "Message",
                newName: "FriendRealId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ContactRealId",
                table: "Message",
                newName: "IX_Message_FriendRealId");

            migrationBuilder.RenameColumn(
                name: "Server",
                table: "Contact",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Last",
                table: "Contact",
                newName: "User");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Contact",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Contact",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    RealId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendOf = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Server = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.RealId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Friend_FriendRealId",
                table: "Message",
                column: "FriendRealId",
                principalTable: "Friend",
                principalColumn: "RealId");
        }
    }
}
