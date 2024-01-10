using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class SettingDatasUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3210), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3211) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3213), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3214) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3215), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3217), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3219), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3282), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3284), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3286), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3188), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3191), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3195), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3309), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3312), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3314), "7/135 Saint St. London" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3315), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3317), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDeleted", "UpdatedDate", "Value" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3321), "Address2", false, new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3321), "1130/5 Louis III St. New York" },
                    { 8, new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3322), "Phone2", false, new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3323), "+18088 625 4251" },
                    { 9, new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3324), "Email2", false, new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3325), "info@lawyersattorneys.com" }
                });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3010), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3021) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3028), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3342), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3343) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3348), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3349) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7854), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7856), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7857) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7858), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7860), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7862), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7862) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7877), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7919), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7921), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7922), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7924), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7925), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7831), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7831) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7833), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7834) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7836), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7836) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7838), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7943), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7945), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate", "Value" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7948), "Example Street 98, HH2 BacHa, New York, USA" });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7951), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7952), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7641), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7651) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7655), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7656) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7967), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7970), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7972), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7973), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7974) });
        }
    }
}
