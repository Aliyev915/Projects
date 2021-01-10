using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class CreateSkillAndTeacherInfoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeacherInfoId",
                table: "Teachers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Language = table.Column<int>(nullable: false),
                    TeamLeader = table.Column<int>(nullable: false),
                    Development = table.Column<int>(nullable: false),
                    Design = table.Column<int>(nullable: false),
                    Innovation = table.Column<int>(nullable: false),
                    Communication = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeachersInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Degree = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    Hobby = table.Column<string>(nullable: true),
                    Faculty = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Skype = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeachersInfo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_TeacherInfoId",
                table: "Teachers",
                column: "TeacherInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Skills_SkillId",
                table: "Teachers",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_TeachersInfo_TeacherInfoId",
                table: "Teachers",
                column: "TeacherInfoId",
                principalTable: "TeachersInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Skills_SkillId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_TeachersInfo_TeacherInfoId",
                table: "Teachers");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "TeachersInfo");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SkillId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_TeacherInfoId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "TeacherInfoId",
                table: "Teachers");
        }
    }
}
