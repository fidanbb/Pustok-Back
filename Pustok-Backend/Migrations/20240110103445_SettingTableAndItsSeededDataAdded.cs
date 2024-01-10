using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class SettingTableAndItsSeededDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5319) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5321), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5322) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5324), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5325) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5327), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5330), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5354), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5356) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5357), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5360), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5361) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5362), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5363) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5364), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5365) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5366), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5367) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5280), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5282) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5286), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5288), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5289) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5291), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5292) });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDeleted", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5468), "HeaderLogo", false, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5469), "logo.webp" },
                    { 2, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5471), "FooterLogo", false, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5472), "logo--footer.webp" },
                    { 3, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5473), "Address", false, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5475), "Example Street 98, HH2 BacHa, New York, USA" },
                    { 4, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5476), "Phone", false, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5477), "+18088 234 5678" },
                    { 5, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5479), "Email", false, new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5479), "support@hastech.com" }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5064), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5083), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5084) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1117), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1119), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1121), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1124), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1126), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1126) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1143), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1146), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1147) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1148), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1149), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1151), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1153), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1153) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1095), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1095) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1098), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1099) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1100), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1101) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1102), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(905), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(922), new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(923) });
        }
    }
}
