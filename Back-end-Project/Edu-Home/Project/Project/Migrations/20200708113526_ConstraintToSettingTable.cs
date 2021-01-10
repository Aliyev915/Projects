using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class ConstraintToSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TitleImage",
                table: "Settings",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TitleImage",
                table: "Settings",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
