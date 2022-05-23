using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class friend4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Friend_Contact_ContactId",
                table: "Friend");

            migrationBuilder.DropIndex(
                name: "IX_Friend_ContactId",
                table: "Friend");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Friend");

            migrationBuilder.AddColumn<string>(
                name: "FriendOf",
                table: "Friend",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FriendOf",
                table: "Friend");

            migrationBuilder.AddColumn<string>(
                name: "ContactId",
                table: "Friend",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Friend_ContactId",
                table: "Friend",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Friend_Contact_ContactId",
                table: "Friend",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id");
        }
    }
}
