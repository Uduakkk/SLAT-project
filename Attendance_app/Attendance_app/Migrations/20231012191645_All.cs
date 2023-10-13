using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Attendance_app.Migrations
{
    public partial class All : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Lectures_LecturesDataModelId",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_LecturerCourses_Courses_CoursesDataModelId",
                table: "LecturerCourses");

            migrationBuilder.DropIndex(
                name: "IX_LecturerCourses_CoursesDataModelId",
                table: "LecturerCourses");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_LecturesDataModelId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "CoursesDataModelId",
                table: "LecturerCourses");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "LecturesDataModelId",
                table: "Attendees");

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "LecturerCourses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "Attendees",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "LectureId",
                table: "Attendees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StudentId",
                table: "Attendees",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_LecturerCourses_CourseId",
                table: "LecturerCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_LectureId",
                table: "Attendees",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_StudentId",
                table: "Attendees",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Lectures_LectureId",
                table: "Attendees",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Students_StudentId",
                table: "Attendees",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LecturerCourses_Courses_CourseId",
                table: "LecturerCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Lectures_LectureId",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Students_StudentId",
                table: "Attendees");

            migrationBuilder.DropForeignKey(
                name: "FK_LecturerCourses_Courses_CourseId",
                table: "LecturerCourses");

            migrationBuilder.DropIndex(
                name: "IX_LecturerCourses_CourseId",
                table: "LecturerCourses");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_LectureId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_StudentId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "LectureId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Attendees");

            migrationBuilder.AlterColumn<string>(
                name: "CourseId",
                table: "LecturerCourses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "CoursesDataModelId",
                table: "LecturerCourses",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Attendees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LecturesDataModelId",
                table: "Attendees",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LecturerCourses_CoursesDataModelId",
                table: "LecturerCourses",
                column: "CoursesDataModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_LecturesDataModelId",
                table: "Attendees",
                column: "LecturesDataModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Lectures_LecturesDataModelId",
                table: "Attendees",
                column: "LecturesDataModelId",
                principalTable: "Lectures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LecturerCourses_Courses_CoursesDataModelId",
                table: "LecturerCourses",
                column: "CoursesDataModelId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
