using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolwManualKeys.Migrations
{
    public partial class Test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Grade",
                table: "Enrollment",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Enrollment");
        }
    }
}
