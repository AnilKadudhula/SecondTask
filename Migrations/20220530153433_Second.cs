using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondTask.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "EmployeeAge", "EmployeeID", "EmployeeName" },
                values: new object[] { 1, 20, 101, "Hi-Tech" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "EmployeeAge", "EmployeeID", "EmployeeName" },
                values: new object[] { 2, 20, 2, "Hi-Tech" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "EmployeeAge", "EmployeeID", "EmployeeName" },
                values: new object[] { 3, 20, 3, "Hi-Tech" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
