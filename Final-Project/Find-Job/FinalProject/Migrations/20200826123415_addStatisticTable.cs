using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class addStatisticTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Icon = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, "<i class='far fa-user'></i>", "Members" },
                    { 2, "<i class='fas fa-briefcase'></i>", "Jobs" },
                    { 3, "<i class='far fa-file-alt'></i>", "Resumes" },
                    { 4, "<i class='fas fa-industry'></i>", "Companies" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");
        }
    }
}
