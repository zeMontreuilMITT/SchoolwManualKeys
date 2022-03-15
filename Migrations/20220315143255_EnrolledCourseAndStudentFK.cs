using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolwManualKeys.Migrations
{
    public partial class EnrolledCourseAndStudentFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_CourseNumber",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_StudentNumber",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_StudentNumber",
                table: "Enrollment");

            migrationBuilder.RenameColumn(
                name: "StudentNumber",
                table: "Enrollment",
                newName: "EnrolledStudentNumber");

            migrationBuilder.RenameColumn(
                name: "CourseNumber",
                table: "Enrollment",
                newName: "EnrolledStudent");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_CourseNumber",
                table: "Enrollment",
                newName: "IX_Enrollment_EnrolledStudent");

            migrationBuilder.AddColumn<int>(
                name: "EnrolledCourseNumber",
                table: "Enrollment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_EnrolledCourseNumber",
                table: "Enrollment",
                column: "EnrolledCourseNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_EnrolledCourseNumber",
                table: "Enrollment",
                column: "EnrolledCourseNumber",
                principalTable: "Course",
                principalColumn: "CourseNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_EnrolledStudent",
                table: "Enrollment",
                column: "EnrolledStudent",
                principalTable: "Student",
                principalColumn: "StudentNumber",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Course_EnrolledCourseNumber",
                table: "Enrollment");

            migrationBuilder.DropForeignKey(
                name: "FK_Enrollment_Student_EnrolledStudent",
                table: "Enrollment");

            migrationBuilder.DropIndex(
                name: "IX_Enrollment_EnrolledCourseNumber",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "EnrolledCourseNumber",
                table: "Enrollment");

            migrationBuilder.RenameColumn(
                name: "EnrolledStudentNumber",
                table: "Enrollment",
                newName: "StudentNumber");

            migrationBuilder.RenameColumn(
                name: "EnrolledStudent",
                table: "Enrollment",
                newName: "CourseNumber");

            migrationBuilder.RenameIndex(
                name: "IX_Enrollment_EnrolledStudent",
                table: "Enrollment",
                newName: "IX_Enrollment_CourseNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollment_StudentNumber",
                table: "Enrollment",
                column: "StudentNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Course_CourseNumber",
                table: "Enrollment",
                column: "CourseNumber",
                principalTable: "Course",
                principalColumn: "CourseNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Enrollment_Student_StudentNumber",
                table: "Enrollment",
                column: "StudentNumber",
                principalTable: "Student",
                principalColumn: "StudentNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
