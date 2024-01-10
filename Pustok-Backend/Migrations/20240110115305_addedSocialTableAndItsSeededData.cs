using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedSocialTableAndItsSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

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
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7947), new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7948) });

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

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreatedDate", "IconName", "Link", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7967), "fa-brands fa-facebook-f", "https://www.facebook.com/", false, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7968) },
                    { 2, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7970), "fa-brands fa-twitter", "https://twitter.com/", false, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7970) },
                    { 3, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7972), "fa-brands fa-google", "https://www.google.com/", false, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7972) },
                    { 4, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7973), "fa-brands fa-youtube", "https://www.youtube.com/", false, new DateTime(2024, 1, 10, 15, 53, 4, 337, DateTimeKind.Local).AddTicks(7974) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Socials");

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

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2751), new DateTime(2024, 1, 10, 15, 10, 16, 52, DateTimeKind.Local).AddTicks(2752) });

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
    }
}
