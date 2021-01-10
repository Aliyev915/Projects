using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class AddColumnToBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Bio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FooterLogo",
                table: "Bio",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Bio");

            migrationBuilder.DropColumn(
                name: "FooterLogo",
                table: "Bio");
        }
    }
}
