using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class messagesArray : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Contact_ContactId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_ContactId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Message");

            migrationBuilder.AddColumn<int>(
                name: "FriendRealId",
                table: "Message",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_FriendRealId",
                table: "Message",
                column: "FriendRealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Friend_FriendRealId",
                table: "Message",
                column: "FriendRealId",
                principalTable: "Friend",
                principalColumn: "RealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Friend_FriendRealId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_FriendRealId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "FriendRealId",
                table: "Message");

            migrationBuilder.AddColumn<string>(
                name: "ContactId",
                table: "Message",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Message_ContactId",
                table: "Message",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Contact_ContactId",
                table: "Message",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id");
        }
    }
}
