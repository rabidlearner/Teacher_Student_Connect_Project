using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Teacher_Student_Connect_Project.Migrations
{
    public partial class testsavetodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecializationName",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubjectName",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BatchYear",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Dob",
                table: "Students",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Students",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dob",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SpecializationName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SubjectName",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "BatchYear",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Dob",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Students");
        }
    }
}
