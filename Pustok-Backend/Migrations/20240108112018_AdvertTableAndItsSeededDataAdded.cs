using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class AdvertTableAndItsSeededDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adverts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adverts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Adverts",
                columns: new[] { "Id", "CreatedDate", "Header", "Image", "SoftDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7333), null, "promo-banner-with-text.webp", false, null, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7333) },
                    { 2, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7335), null, "promo-banner-with-text-2.webp", false, null, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7336) },
                    { 3, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7337), "Buy 3. Get Free 1.", "promo-banner-mid.webp", false, "50% off for selected products in Pustok.", new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7337) },
                    { 4, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7339), "$26.00", "promo-banner-small.webp", false, "Praise for The Night Child", new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7340) },
                    { 5, new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7341), "I Love This Idea!", "promo-banner-full.webp", false, "Cover up front of book and leave summary", new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7342) }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7310), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7311) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7313), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7315), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7317), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7144), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7144) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adverts");

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5373), new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5374) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5376), new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5377) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5379), new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5379) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5381), new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5381) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5136), new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5156) });
        }
    }
}
