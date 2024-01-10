using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedBrandTableAndTheirSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

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

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "Image", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1143), "brand-1.webp", false, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1144) },
                    { 2, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1146), "brand-2.webp", false, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1147) },
                    { 3, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1148), "brand-3.webp", false, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1149) },
                    { 4, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1149), "brand-4.webp", false, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1150) },
                    { 5, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1151), "brand-5.webp", false, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1152) },
                    { 6, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1153), "brand-6.webp", false, new DateTime(2024, 1, 8, 17, 22, 37, 358, DateTimeKind.Local).AddTicks(1153) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7333), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7333) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7335), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7336) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7339), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 1, 8, 15, 20, 17, 830, DateTimeKind.Local).AddTicks(7342) });

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
    }
}
