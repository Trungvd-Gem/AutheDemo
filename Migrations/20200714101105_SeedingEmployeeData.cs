using Microsoft.EntityFrameworkCore.Migrations;

namespace AutheDemo.Migrations
{
    public partial class SeedingEmployeeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AvatarPath", "Department", "Email", "FullName" },
                values: new object[,]
                {
                    { 1, "images/gem.png", ".Net IT", "trungvd@gemvietnam.com", " Vu Duc Trung" },
                    { 2, "images/gem.png", ".Net IT", "hungnv@gemvietnam.com", " Nguyen Van Hung" },
                    { 3, "images/gem.png", ".Net IT", "Namhv@gemvietnam.com", " Hoang Van Nam" },
                    { 4, "images/gem.png", "Java IT", "DatNQ@gemvietnam.com", "Nguyen Quy Dat" },
                    { 5, "images/gem.png", "Java IT", "DuyDN@gemvietnam.com", "Dao Ngoc Duy" },
                    { 6, "images/gem.png", "Mobile IT", "DuyetDD@gemvietnam.com", " Dao Duc Duyet" },
                    { 7, "images/gem.png", "Mobile IT", "DatPT@gemvietnam.com", "Pham Thanh Dat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
