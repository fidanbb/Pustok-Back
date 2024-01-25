using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedWishlistTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wishlists_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "WishlistProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WishlistId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishlistProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishlistProducts_Wishlists_WishlistId",
                        column: x => x.WishlistId,
                        principalTable: "Wishlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1268), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1269), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1270) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1271), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1271) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1273), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1274), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1275) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1646), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1647), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1648) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1649), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1650), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1651), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1652), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1653), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1654), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1655), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1657), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1658), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1683), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1684), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1685), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1687), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1687) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1435), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1436), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1436) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1437), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1438), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1439), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1440) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1440), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1441) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1441), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1442) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1442), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1443) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1444), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1444) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1445), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1445) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1607), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1609), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1610), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1611), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1612), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1614), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1616), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1617), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1618) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1489), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1490) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1491), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1491) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1492), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1493) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1494), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1494) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1495), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1496), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1497) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1498), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1499), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1500), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1501) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1502), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1502) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1503), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1503) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1504), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1505) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1529), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1529) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1530), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1531) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1532), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1532) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1533), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1534), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1537), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1537) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1538), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1552), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1554), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1555), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1556), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1557), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1558), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1559), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1560), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1562), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1562) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1563), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1564), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1565), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1565) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1566), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1567), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1568) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1568), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1569), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1570) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1570), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1571), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1572) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1573), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1573) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1574), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1575), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1576), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1576) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1577), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1578), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1579), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1579) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1580), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1581), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1582) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1582), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1583), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1584), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1586), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1587), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1588), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1589), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1590), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1591), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1458));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1470));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1475));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1476));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1285), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1286) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1287), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1287) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1288), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1288) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1289), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1289) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1290), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1290) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1291), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1291) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1630), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1631), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1632), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1633), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1634) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1634), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1635), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1636), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1383), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1383) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1699), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1700), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1702), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1703), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1704), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1705), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1706), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1707), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1709), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1927), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1929), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1929) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1930), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1932), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1933), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1934), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1935) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1935), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1937), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1938), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1938) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1939), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1940), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1942), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1943), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1944), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1945) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1945), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1766), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1769), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1769) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1770), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1771) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1772), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1772) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1773), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1773) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1774), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1775), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1776) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1776), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1778), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1778) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1779), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1779) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1780), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1780) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1781), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1782) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1782), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1783) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1784), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1784) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1785), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1786), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1787), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1788) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1789), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1790), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1791), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1791) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1792), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1792) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1793), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1794), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1796), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1796) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1797), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1798), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1799), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1801), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1802) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1803), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1857), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1859), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1860), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1860) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1861), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1862), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1863) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1863), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1864), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1865), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1866), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1868), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1868) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1869), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1870), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1871), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1871) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1872), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1873), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1874), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1875) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1875), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1876), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1877), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1878), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1879), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1881), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1882), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1882) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1883), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1884), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1884) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1885), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1886), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1887), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1888), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1889), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1890), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1891), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1892), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1893) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1894), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1895), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1896), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1897), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1897) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1898), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1899), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1900) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1900), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1901) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1901), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1902) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1902), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1903), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1904), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1905), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1906) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1907), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1907) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1908), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1909), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1909) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1910), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1910) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1911), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1911) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1912), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1912) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1251), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1251) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1253), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1254), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1255) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1256), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1256) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1303), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1303) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1306), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1306) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1307), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1307) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1308), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1308) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1337), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1338) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1339), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1340), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1340) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1341), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1342), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1343) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1114), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1129), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1355), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1355) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1357), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1357) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1358), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1358) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1359), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1370), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1371) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1373), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1373) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1414), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1415) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1416), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1417), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1418) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1419), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1419) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1420), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1420) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1421), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1421) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1422), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1422) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1423) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1395), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1396) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1397), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1398) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1398), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1399) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1400), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1400) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1401), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1401) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 1, 25, 17, 47, 57, 47, DateTimeKind.Local).AddTicks(1402) });

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_ProductId",
                table: "WishlistProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistProducts_WishlistId",
                table: "WishlistProducts",
                column: "WishlistId");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_AppUserId",
                table: "Wishlists",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WishlistProducts");

            migrationBuilder.DropTable(
                name: "Wishlists");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4053), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4060), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4060) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4440), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4442), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4442) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4443), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4444), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4445) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4450) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4451), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4453), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4453) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4454), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4454) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4455), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4455) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4456), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4458) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4222), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4223), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4224), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4225), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4226) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4227), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4227) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4228), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4228) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4229), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4230), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4231), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4231) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4232) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4399), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4401), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4402), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4403) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4404), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4405), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4406), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4407), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4409), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4409) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4410), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4411), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4412) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4278), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4280), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4281), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4283), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4283) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4284), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4285) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4285), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4287), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4288), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4288) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4289), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4290), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4292), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4293), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4294), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4295), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4296) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4297), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4298), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4299), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4300), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4301), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4303), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4319), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4319) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4320), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4321) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4322), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4323), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4324), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4324) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4325), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4326), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4327) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4327), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4328), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4329) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4329), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4330) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4330), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4331) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4332), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4333), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4333) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4334), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4334) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4335), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4336), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4337), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4337) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4338), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4339), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4340), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4341) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4341), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4342) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4342), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4344), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4370), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4371) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4371), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4373), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4374), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4375), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4376), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4377), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4379), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4379) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4380), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4381), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4382), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4382) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4383), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4384) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4384), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4254));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4259));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4264));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4072) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4081) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4081), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4422), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4424), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4425), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4425) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4426), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4426) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4427), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4428), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4429), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4144), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4469), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4469) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4473), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4474), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4477), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4477) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4479), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4479) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4480), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4481) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4780), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4783), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4784), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4785), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4787), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4788), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4789), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4790), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4791), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4793), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4794), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4795), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4796), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4797) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4590), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4595) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4600), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4602), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4603), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4603) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4604), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4605) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4607) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4608), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4609), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4610) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4613), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4615) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4617), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4622), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4625) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4626), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4627), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4628), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4629) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4644), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4646), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4647), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4648) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4648), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4649), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4651), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4651) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4652), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4652) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4653), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4653) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4654), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4654) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4655), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4656) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4656), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4657) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4657), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4658), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4659) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4661), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4662) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4663), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4664) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4665), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4666), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4667) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4668), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4669) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4670), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4671), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4671) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4672), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4673) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4673), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4674) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4674), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4675) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4676), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4677), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4677) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4678), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4678) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4679), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4680) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4740), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4741) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4742) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4744), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4744) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4747), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4748) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4749) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4750), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4750) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4751) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4753) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4755) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4756), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4757) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4760) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4761), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4504));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4507));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4037), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4039) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4040), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4093), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4097), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4098) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4099), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4101), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4102) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4102), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4103) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4104), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4105), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4106) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(3905), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(3921), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(3922) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4117), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4117) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4119), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4119) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4120), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4120) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4121), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4121) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4131), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4132) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4134), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4134) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4173), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4174) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4201), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4203), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4203) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4204), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4204) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4205), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4206) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4206), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4207) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4207), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4208), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4155), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4157), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4157) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4158), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4159), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4161), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4162), new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4162) });
        }
    }
}
