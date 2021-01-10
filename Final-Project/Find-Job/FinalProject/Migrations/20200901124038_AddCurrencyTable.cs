using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalProject.Migrations
{
    public partial class AddCurrencyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "Jobs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2020, 9, 1, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Demands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Education",
                value: "<li>M.B.S / M.B.A under National University with CA course complete</li> <li>3 or more years of professional design experience</li> <li>Excellent communication skills, most notably a demonstrated ability to solicit and address creative and design feedback</li> <li>Masters of library science any Green University</li> <li>BA/BS degree in a technical field or equivalent practical experience</li>");

            migrationBuilder.UpdateData(
                table: "Demands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Education",
                value: "<li>Explore and design dynamic and compelling consumer experiences</li><li>Have sound knowledge of commercial activities</li><li>Build next-generation web applications with a focus on the client side</li><li>The applicants should have experience in the following areas</li>");

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CurrencyId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CurrencyId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_CurrencyId",
                table: "Jobs",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Currencies_CurrencyId",
                table: "Jobs",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Currencies_CurrencyId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_CurrencyId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "Jobs");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Time",
                value: new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "Time",
                value: new DateTime(2020, 8, 30, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Demands",
                keyColumn: "Id",
                keyValue: 1,
                column: "Education",
                value: "M.B.S / M.B.A under National University with CA course complete_ 3 or more years of professional design experience_ Excellent communication skills, most notably a demonstrated ability to solicit and address creative and design feedback_ Masters of library science any Green University_ BA/BS degree in a technical field or equivalent practical experience");

            migrationBuilder.UpdateData(
                table: "Demands",
                keyColumn: "Id",
                keyValue: 2,
                column: "Education",
                value: "Explore and design dynamic and compelling consumer experiences_Have sound knowledge of commercial activities_Build next-generation web applications with a focus on the client side_The applicants should have experience in the following areas");
        }
    }
}
