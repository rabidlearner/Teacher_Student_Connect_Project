using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher_Student_Connect_Project.Migrations
{
    public partial class adminmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Subjects_SubjectId",
                table: "Documents");

            migrationBuilder.DropIndex(
                name: "IX_Documents_SubjectId",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Documents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_DocumentId",
                table: "Subjects",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_AdminId",
                table: "Documents",
                column: "AdminId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Admins_AdminId",
                table: "Documents",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Subjects_Documents_DocumentId",
                table: "Subjects",
                column: "DocumentId",
                principalTable: "Documents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Admins_AdminId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Subjects_Documents_DocumentId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Subjects_DocumentId",
                table: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Documents_AdminId",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Documents");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_SubjectId",
                table: "Documents",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Subjects_SubjectId",
                table: "Documents",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
