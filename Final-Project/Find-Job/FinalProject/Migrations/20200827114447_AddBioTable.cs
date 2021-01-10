using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class AddBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Logo = table.Column<string>(maxLength: 250, nullable: false),
                    BlackLogo = table.Column<string>(maxLength: 250, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Web = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bio", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bio",
                columns: new[] { "Id", "Address", "BlackLogo", "Email", "Logo", "Phone", "Web" },
                values: new object[] { 1, "20/F Green Road, Dhaka", "black-logo.png", "info@themevessel.com", "logo.png", "+55 417 634 7071", "info@themevessel.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bio");
        }
    }
}
