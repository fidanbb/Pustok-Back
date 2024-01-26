using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedCartTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carts",
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
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartProducts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4464), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4466), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4467) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4467), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4470), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4979), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4979) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4981) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4982), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4982) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4983), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4984) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4985), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4985) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4986), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4987), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4988) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4988), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4989) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4990) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4991), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4992), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4992) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4994) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4994), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4995), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4996) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4997), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4997) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4614), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4614) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4615), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4616), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4617) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4618), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4618) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4619), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4620) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4620), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4621) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4621), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4623), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4623) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4624), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4624) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4625), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4626) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4862), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4863) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4864), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4865) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4866), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4867) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4868), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4868) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4934) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4936), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4936) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4937), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4939), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4939) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4940), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4941) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4941), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4942) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4754) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4757), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4758) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4759), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4759) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4760), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4761) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4762), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4763) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4764), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4765), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4765) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4766), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4767) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4768), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4768) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4769), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4771), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4771) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4772), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4773) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4773), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4774) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4775), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4775) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4776), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4777) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4778), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4779), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4781), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4781) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4782), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4798), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4799) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4800), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4800) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4801), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4802) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4803), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4804), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4806), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4807), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4808), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4809) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4810), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4811), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4812), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4813) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4814), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4814) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4815), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4816) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4816), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4817) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4818), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4818) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4819), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4819) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4820), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4821) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4823), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4823) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4824), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4825) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4825), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4826) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4827), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4827) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4828), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4828) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4829), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4830) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4830), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4831) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4831), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4832) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4833), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4833) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4834), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4834) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4835), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4836) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4836), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4837) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4838), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4838) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4839), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4839) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4840), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4841) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4841), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4842) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4843), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4843) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4844), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4844) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4642));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4647));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4649));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4729));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4732));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4736));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4484), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4485) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4486), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4487) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4488), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4488) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4489), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4490) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4490), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4492), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4492) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4956), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4958), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4958) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4959), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4960) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4961), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4961) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4962), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4963) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4964) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4965), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4965) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4559), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5012), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5012) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5014), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5014) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5015), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5016) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5017), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5017) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5018), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5019), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5020) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5020), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5021) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5022), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5022) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5023), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5024) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5024), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5025) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5331), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5333), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5334) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5335), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5336) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5337), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5337) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5340), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5340) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5341), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5343), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5343) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5344), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5345) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5346), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5346) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5347), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5348) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5348), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5350), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5350) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5351), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5352) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5352), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5353) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5121), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5124), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5126), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5128), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5129), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5130) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5131), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5132), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5133) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5134), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5135), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5137), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5137) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5138), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5140), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5141), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5142), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5143) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5144), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5144) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5145), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5146) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5147), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5148), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5150), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5150) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5151), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5152), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5153) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5154), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5155), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5156) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5157), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5158), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5159) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5160), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5161), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5162) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5163), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5164), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5165) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5184), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5186), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5187), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5188) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5188), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5190), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5191), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5193), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5194), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5194) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5195), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5196) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5197), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5198), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5198) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5199), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5200), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5201) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5202), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5203), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5203) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5204), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5205) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5205), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5206) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5207), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5207) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5208), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5209), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5211), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5211) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5212), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5213), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5214), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5216), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5216) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5217), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5218), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5219) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5220), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5221), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5222), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5223), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5225), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5226), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5227), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5228) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5228), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5230), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5230) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5231), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5232), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5234), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5235), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5235) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5236), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5237), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5238) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5239), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5240), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5241), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5242), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5244), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5244) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5245), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5246), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5247) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5247), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5249), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4445), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4446) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4447), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4449), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4449) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4450), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4505), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4507), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4508), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4510), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4512), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4512) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4513), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4514), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4515) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4516), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4516) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4517), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4248), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4259) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4263), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4263) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4529), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4531), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4532) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4533), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4534), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4535) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4547), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4548), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4591), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4591) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4592), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4594), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4594) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4595), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4596), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4598), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4598) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4599), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4601), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4570), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4572), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4574), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4575) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4575), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4576) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4577), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4578), new DateTime(2024, 1, 26, 18, 11, 37, 463, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_CartId",
                table: "CartProducts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartProducts_ProductId",
                table: "CartProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_AppUserId",
                table: "Carts",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProducts");

            migrationBuilder.DropTable(
                name: "Carts");

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
        }
    }
}
