using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedSubscribeTableAndItsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subscribes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscribes", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Subscribes",
                columns: new[] { "Id", "CreatedDate", "Email", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4851), "surac@gmail.com", false, new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4852) },
                    { 2, new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4852), "kubra@gmail.com", false, new DateTime(2024, 1, 10, 22, 36, 30, 45, DateTimeKind.Local).AddTicks(4853) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subscribes");

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3314), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3314) });

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

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3321), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 1, 10, 16, 21, 28, 802, DateTimeKind.Local).AddTicks(3325) });

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
    }
}
