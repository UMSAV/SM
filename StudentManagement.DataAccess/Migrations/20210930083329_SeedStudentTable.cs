using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentManagement.DataAccess.Migrations
{
    public partial class SeedStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName", "Login", "MiddleName", "Parol", "PassportNumber" },
                values: new object[] { 1, "admin", "Muhammadqodir", "To'ychiboyev", "admin", "Jumaboy o'g'li", "111", "AB 0000000" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Department", "FirstName", "LastName", "Login", "MiddleName", "Parol", "PassportNumber" },
                values: new object[] { 2, "user", "Jo'rabek", "To'xtasinov", "user", "Otabek o'g'li", "222", "AB 0000000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
