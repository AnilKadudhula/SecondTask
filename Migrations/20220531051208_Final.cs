using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SecondTask.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeAge",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmployeeName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                column: "Name",
                value: "Home");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                column: "Name",
                value: "Open");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3,
                column: "Name",
                value: "Completed");

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 4, "Pending" },
                    { 5, "Pree Review" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "EmployeeName");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeAge",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "EmployeeAge", "EmployeeID", "EmployeeName" },
                values: new object[] { 20, 101, "Hi-Tech" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "EmployeeAge", "EmployeeID", "EmployeeName" },
                values: new object[] { 20, 2, "Hi-Tech" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "EmployeeAge", "EmployeeID", "EmployeeName" },
                values: new object[] { 20, 3, "Hi-Tech" });
        }
    }
}
