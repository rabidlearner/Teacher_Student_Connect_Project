using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher_Student_Connect_Project.Migrations
{
    public partial class documentattachmentfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attachment",
                table: "Documents");

            migrationBuilder.AddColumn<string>(
                name: "AttachmentLocale",
                table: "Documents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentLocale",
                table: "Documents");

            migrationBuilder.AddColumn<string>(
                name: "Attachment",
                table: "Documents",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
