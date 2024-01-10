using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedNewDataToSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2395), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2398), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2400), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2403), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2406), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2694), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2697) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2700), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2702), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2704), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2705) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2706), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2709), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2709) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2365), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2369), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2371), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2374), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2739), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2740) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2742), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2743) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2745), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2747), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2748) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2749), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2750) });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDeleted", "UpdatedDate", "Value" },
                values: new object[] { 6, new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2751), "PaymentMethod", false, new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2752), "payment.webp" });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2090), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2110), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2111) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6);

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

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5468), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5469) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5471), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5472) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5473), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5475) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5476), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5477) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5479), new DateTime(2024, 1, 10, 14, 34, 45, 140, DateTimeKind.Local).AddTicks(5479) });

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
    }
}
