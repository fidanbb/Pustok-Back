using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class ContactMessageTableAndItsDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMessages", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8194), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8219), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8221), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8225), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.InsertData(
                table: "ContactMessages",
                columns: new[] { "Id", "CreatedDate", "Email", "Message", "Name", "SoftDeleted", "UpdatedDate" },
                values: new object[] { 1, new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8300), "fidanbb@code.edu.az", "Helllooo", "Fidan Bashirova", false, new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8247), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8252), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(7985), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8001), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8270), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8288), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8290) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMessages");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4790) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4805), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4807) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4809), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4777), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4779) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4818), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4820) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4822), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4824), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4825), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4826), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4827), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4666) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4839), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4840) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4851), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4852) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4852), new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4853) });
        }
    }
}
