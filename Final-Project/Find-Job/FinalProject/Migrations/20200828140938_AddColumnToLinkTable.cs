using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class AddColumnToLinkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Controller",
                table: "Links",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icon",
                table: "Links",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Dasboard", "<i class='fas fa-tachometer-alt'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Dashboard", "<i class='fas fa-plus'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Candidate", "<i class='fas fa-user-check'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Job", "<i class='fas fa-briefcase'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Blog", "<i class='fas fa-blog'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Message", "<i class='far fa-envelope'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Profile", "<i class='fas fa-user-edit'></i>" });

            migrationBuilder.UpdateData(
                table: "Links",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Controller", "Icon" },
                values: new object[] { "Logout", "<i class='fas fa-sign-out-alt'></i>" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Controller",
                table: "Links");

            migrationBuilder.DropColumn(
                name: "Icon",
                table: "Links");
        }
    }
}
