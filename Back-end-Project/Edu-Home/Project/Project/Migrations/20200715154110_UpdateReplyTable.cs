using Microsoft.EntityFrameworkCore.Migrations;

namespace Project.Migrations
{
    public partial class UpdateReplyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_AppUserId1",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_AppUserId1",
                table: "Replies");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Replies");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "Replies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Replies_AppUserId",
                table: "Replies",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_AppUserId",
                table: "Replies",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Replies_AspNetUsers_AppUserId",
                table: "Replies");

            migrationBuilder.DropIndex(
                name: "IX_Replies_AppUserId",
                table: "Replies");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Replies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Replies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Replies_AppUserId1",
                table: "Replies",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Replies_AspNetUsers_AppUserId1",
                table: "Replies",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
