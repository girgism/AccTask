using Microsoft.EntityFrameworkCore.Migrations;

namespace AccFlex.Migrations
{
    public partial class updateStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_ClassID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GenderID",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderID",
                table: "Students",
                column: "GenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_ClassID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_GenderID",
                table: "Students");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassID",
                table: "Students",
                column: "ClassID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_GenderID",
                table: "Students",
                column: "GenderID",
                unique: true);
        }
    }
}
