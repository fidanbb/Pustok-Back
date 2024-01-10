using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class ServicesTableAndItsDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreatedDate", "Description", "IconName", "SoftDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5373), "Orders over $500", "fas fa-shipping-fast", false, "Free Shipping Item", new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5374) },
                    { 2, new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5376), "100% money back", "fas fa-redo-alt", false, "Money Back Guarantee", new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5377) },
                    { 3, new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5379), "Lorem ipsum dolor amet", "fas fa-piggy-bank", false, "Cash On Delivery", new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5379) },
                    { 4, new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5381), "Call us : + 0123.4567.89", "fas fa-life-ring", false, "Help & Support", new DateTime(2024, 1, 7, 20, 10, 24, 301, DateTimeKind.Local).AddTicks(5381) }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 6, 17, 34, 23, 779, DateTimeKind.Local).AddTicks(5507), new DateTime(2024, 1, 6, 17, 34, 23, 779, DateTimeKind.Local).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 6, 17, 34, 23, 779, DateTimeKind.Local).AddTicks(5520), new DateTime(2024, 1, 6, 17, 34, 23, 779, DateTimeKind.Local).AddTicks(5521) });
        }
    }
}
