using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class messages3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Contact_contactId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_contactId",
                table: "Message");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Message_contactId",
                table: "Message",
                column: "contactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Contact_contactId",
                table: "Message",
                column: "contactId",
                principalTable: "Contact",
                principalColumn: "RealId");
        }
    }
}
