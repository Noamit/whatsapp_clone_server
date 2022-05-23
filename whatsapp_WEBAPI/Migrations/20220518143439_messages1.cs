using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class messages1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Contact_ContactRealId",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "ContactRealId",
                table: "Message",
                newName: "contactId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_ContactRealId",
                table: "Message",
                newName: "IX_Message_contactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Contact_contactId",
                table: "Message",
                column: "contactId",
                principalTable: "Contact",
                principalColumn: "RealId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Contact_contactId",
                table: "Message");

            migrationBuilder.RenameColumn(
                name: "contactId",
                table: "Message",
                newName: "ContactRealId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_contactId",
                table: "Message",
                newName: "IX_Message_ContactRealId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Contact_ContactRealId",
                table: "Message",
                column: "ContactRealId",
                principalTable: "Contact",
                principalColumn: "RealId");
        }
    }
}
