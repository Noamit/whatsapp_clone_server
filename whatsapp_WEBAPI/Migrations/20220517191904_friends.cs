using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace whatsapp_WEBAPI.Migrations
{
    public partial class friends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contact_Contact_ContactId",
                table: "Contact");

            migrationBuilder.DropIndex(
                name: "IX_Contact_ContactId",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Contact");

            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Server = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Friend_Contact_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contact",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Friend_ContactId",
                table: "Friend",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.AddColumn<string>(
                name: "ContactId",
                table: "Contact",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contact_ContactId",
                table: "Contact",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contact_Contact_ContactId",
                table: "Contact",
                column: "ContactId",
                principalTable: "Contact",
                principalColumn: "Id");
        }
    }
}
