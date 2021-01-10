using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class AddLinkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "Jobs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Companies",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                column: "Adress",
                value: " 20/F Green Road, Dhaka");

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2,
                column: "Adress",
                value: " 20/F Green Road, Dhaka");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Experience",
                value: "1-2");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Experience",
                value: "2-3");

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dashboard" },
                    { 2, "Post a New Job" },
                    { 3, "Manage Candidate" },
                    { 4, "Manage Jobs" },
                    { 5, "Manage Blogs" },
                    { 6, "Message" },
                    { 7, "Edit Profile" },
                    { 8, "Logout" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropColumn(
                name: "Experience",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Companies");
        }
    }
}
