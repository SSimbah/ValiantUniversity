using Microsoft.EntityFrameworkCore.Migrations;

namespace ValiantUniversity.Migrations
{
    public partial class studentModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmailAddress",
                table: "Student",
                newName: "StudentEmail");

            migrationBuilder.RenameColumn(  
                name: "ID",
                table: "Student",
                newName: "StudentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentEmail",
                table: "Student",
                newName: "EmailAddress");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Student",
                newName: "ID");
        }
    }
}
