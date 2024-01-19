using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedProductRelatedTablesAndTheirSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    SaleCount = table.Column<int>(type: "int", nullable: false),
                    StockCount = table.Column<int>(type: "int", nullable: false),
                    Sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductComments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductComments_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3141), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3142), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3143) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3143), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3145), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3146), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3147) });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "CreatedDate", "FullName", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3478), "Jane Austen", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3478) },
                    { 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3479), "Charles Dickens", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3480) },
                    { 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3480), "Agatha Christie", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3481) },
                    { 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3481), "F. Scott Fitzgerald", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3482) },
                    { 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3482), "J.K. Rowling", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3483) },
                    { 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3483), "Gabriel Garcia Marquez", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3483) },
                    { 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3484), "Harper Lee", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3484) },
                    { 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3485), "George Orwell", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3485) },
                    { 9, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3486), "Ernest Hemingway", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3487) },
                    { 10, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3487), "Toni Morrison", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3488) },
                    { 11, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3488), "Mark Twain", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3489) },
                    { 12, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3489), "J.R.R. Tolkien", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3490) },
                    { 13, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3490), "Virginia Woolf", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3491) },
                    { 14, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3491), "Leo Tolstoy", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3491) },
                    { 15, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3492), "Emily Brontë", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3492) }
                });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3285), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3287), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3288), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3289), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3290), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3291), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3292), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3293), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3294), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3294) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3295), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3442), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3443) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3444), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3444) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3445), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3445) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3446), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3446) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3447), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3447) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3448), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3449), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3450), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3451), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3452), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3453) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3337), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3337) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3339), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3339) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3340), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3340) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3341), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3341) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3342), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3342) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3343), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3344) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3344), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3345) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3345), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3346) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3346), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3347) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3347), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3349), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3349) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3350), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3350) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3351), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3351) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3352), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3353), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3354), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3354) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3377), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3379), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3380), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3393), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3394), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3395), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3396), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3397), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3399), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3401), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3401) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3403), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3404), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3406), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3407), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3408), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3409), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3410), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3411), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3412), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3413), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3414), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3415), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3416), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3417), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3418), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3419), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3420), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3421), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3422), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3423), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3424), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3425), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3426), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3427), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3158), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3159), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3160), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3161), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3162), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3163), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3462), "Biographies", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3463) },
                    { 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3464), "Business & Money", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3464) },
                    { 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3465), "Children's Books", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3465) },
                    { 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3466), "Comics", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3466) },
                    { 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3466), "Cookbooks", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3467) },
                    { 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3467), "Education", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3468) },
                    { 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3468), "Arts & Photography", false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3469) }
                });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedDate", "Name", "Percent", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3527), "Spring Sale", 15, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3528) },
                    { 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3529), "Back-to-School", 10, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3529) },
                    { 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3530), "Holiday Special", 25, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3530) },
                    { 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3531), "Summer Reading", 20, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3531) },
                    { 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3532), "New Year's Clearance", 30, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3532) },
                    { 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3533), "Weekend Flash Sale", 15, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3533) }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreatedDate", "Name", "Percent", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3534), "Member Exclusive", 10, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3534) },
                    { 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3535), "Book Club Discount", 20, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3535) },
                    { 9, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3536), "Black Friday", 40, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3536) },
                    { 10, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3537), "Fall Frenzy", 15, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3538) }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3126), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3126) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3128), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3128) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3129), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3129) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3130), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3130) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3172), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3174), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3175), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3176), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3176) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3177), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3178), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3204), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3205), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3206) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3207), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(2999), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3015), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3016) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3218), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3218) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3220), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3221), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3221) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3222), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3222) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3232), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3233), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3233) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3268), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3269), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3270), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3271), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3272), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3273), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3274), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3275), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3251), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3253), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3254), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3255), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3256), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3257) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3257), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AuthorId", "CategoryId", "CreatedDate", "Description", "DiscountId", "Name", "Price", "Rate", "SaleCount", "Sku", "SoftDeleted", "StockCount", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the magical realm of Eldoria, where dragons soar and wizards weave spells, embark on a mesmerizing journey with 'The Enchanting Tale.' This epic fantasy novel, written by the acclaimed author Jane Austen, unfolds a captivating narrative of courage, destiny, and enchantment. Join our young protagonist as they navigate through mystical landscapes, encountering mythical creatures and facing formidable challenges.", 1, "The Enchanting Tale", 55m, 3, 5, "ENCTLE123", false, 10, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3549) },
                    { 2, 2, 2, new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delve into the cosmic mysteries with 'Whispers of the Cosmos,' a thought-provoking science fiction masterpiece. Written by the visionary J.R.R. Tolkien, this interstellar journey takes readers beyond the limits of space and time. Join a diverse cast of characters as they unravel the secrets of the universe, encountering extraterrestrial civilizations and confronting the profound questions that echo through the cosmos.", 3, "Whispers of the Cosmos", 43m, 4, 8, "COSMOS456", false, 15, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3553) },
                    { 3, 3, 5, new DateTime(2021, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on a culinary journey with 'Gourmet Adventures,' a delightful cookbook filled with delectable recipes from renowned chefs worldwide. From exotic appetizers to mouth-watering desserts, savor the flavors of diverse cuisines and elevate your culinary skills.", 2, "Gourmet Adventures", 30m, 5, 12, "GOURMET789", false, 20, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3555) },
                    { 4, 4, 6, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Immerse yourself in the past with 'Historical Chronicles,' a collection of meticulously researched historical accounts. Written by F. Scott Fitzgerald, these narratives bring to life the events and characters that shaped our world.", 4, "Historical Chronicles", 46m, 3, 7, "HISTCHRON101", false, 18, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3557) },
                    { 5, 5, 3, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Step into 'Magical Realms,' a enchanting compilation of short stories that blur the lines between reality and fantasy. Crafted by J.K. Rowling, each tale unfolds a world where magic and wonder coexist with the ordinary.", 1, "Magical Realms", 60m, 5, 10, "MAGIREALM222", false, 15, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3560) },
                    { 6, 6, 7, new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover the path to mindful living with 'Mindful Living,' a guide to wellness and self-discovery. In this insightful book by Gabriel Garcia Marquez, learn practical techniques and wisdom to cultivate a balanced and meaningful life.", 3, "Mindful Living", 50m, 3, 15, "MINDLIVE333", false, 25, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3562) },
                    { 7, 7, 4, new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore the world of art with 'Harmony of Colors,' a vibrant collection of paintings and photographs. Authored by Harper Lee, this book celebrates the beauty of visual expression and the emotional resonance of color.", 5, "Harmony of Colors", 55m, 4, 8, "HARMCOLOR444", false, 20, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3564) },
                    { 8, 8, 6, new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dive into the wonders of the 'Animal Kingdom,' a captivating exploration of wildlife and ecosystems. Authored by George Orwell, this book showcases the beauty and diversity of the natural world.", 2, "Animal Kingdom", 30m, 2, 10, "ANIMALKING555", false, 15, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3565) },
                    { 9, 9, 5, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on 'Culinary Adventures,' a gastronomic journey through diverse cuisines and culinary traditions. Authored by Ernest Hemingway, this cookbook brings the joy of cooking to enthusiasts of all skill levels.", 4, "Culinary Adventures", 40m, 5, 12, "CULADVENT666", false, 18, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3567) },
                    { 10, 10, 2, new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on a cosmic adventure with 'Exploring the Cosmos,' a journey into the mysteries of the universe. Authored by Toni Morrison, this science fiction odyssey takes readers on a mind-bending exploration of space and time.", 1, "Exploring the Cosmos", 60m, 5, 15, "COSMOEXP777", false, 22, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3568) },
                    { 11, 11, 1, new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enter the realm of 'Surreal Dreams,' a collection of imaginative short stories that defy conventional reality. Authored by Virginia Woolf, each tale invites readers to explore the boundaries of perception and dreamlike narratives.", 3, "Surreal Dreams", 46m, 4, 11, "SURREALDREAM888", false, 16, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3570) },
                    { 12, 12, 7, new DateTime(2022, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover 'The Art of Serenity,' a guide to mindfulness and inner peace by Leo Tolstoy. This inspirational book offers timeless wisdom and practical insights to navigate the complexities of modern life.", 2, "The Art of Serenity", 35m, 3, 13, "SERENITY999", false, 19, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3571) },
                    { 13, 13, 3, new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on 'Epic Adventures,' a thrilling compilation of action-packed stories from master storyteller Mark Twain. This riveting collection takes readers on a journey through daring escapades, uncharted territories, and the triumph of the human spirit.", 4, "Epic Adventures", 40m, 3, 9, "EPICADV1010", false, 14, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3573) },
                    { 14, 14, 5, new DateTime(2022, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dive into the enchanting world of 'Poetic Musings,' a lyrical journey through the verses of Langston Hughes. This collection of poetry captures the essence of life, love, and the beauty found in the simple moments of existence.", 5, "Poetic Musings", 30m, 4, 10, "POETICMUSE1111", false, 17, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3574) },
                    { 15, 15, 3, new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Immerse yourself in 'Thrilling Escapes,' a captivating collection of suspenseful tales from the brilliant mind of H.G. Wells. This anthology explores the boundaries of imagination and keeps readers on the edge of their seats.", 1, "Thrilling Escapes", 45m, 3, 14, "THRILLESCAPE1212", false, 21, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3576) }
                });

            migrationBuilder.InsertData(
                table: "ProductComments",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "Message", "ProductId", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "0efd01de-4eec-45ff-9de4-f03f9abdf104", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3717), "The intricate plot and well-developed characters in this book kept me hooked from the first page. A must-read for anyone who loves a gripping story!", 1, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3717) },
                    { 2, "122ee49a-1c09-45ba-a6a5-4e94b3be7c85", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3718), "I was pleasantly surprised by the unexpected twists and turns in this book. The author's storytelling style is captivating, making it a compelling read.", 2, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3719) },
                    { 3, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3720), "The emotional depth and thought-provoking themes explored in this book left a lasting impact. I highly recommend it to fellow readers who appreciate profound storytelling.", 3, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3720) },
                    { 4, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3721), "An engaging and well-written book that offers a unique perspective on its subject matter. The author's creativity shines through, making it a standout addition to my reading list.", 4, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3721) },
                    { 5, "0efd01de-4eec-45ff-9de4-f03f9abdf104", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3722), "This book has become one of my all-time favorites. The rich narrative and memorable characters make it a must-read for book enthusiasts. I look forward to exploring more works by the same author.", 5, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3722) },
                    { 6, "122ee49a-1c09-45ba-a6a5-4e94b3be7c85", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3723), "The author's ability to weave together various storylines in this book is truly commendable. It kept me engrossed until the very end, and I can't wait to delve into their other literary creations.", 6, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3723) },
                    { 7, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3724), "A thought-provoking and well-researched book that explores complex themes with clarity. The author's writing style adds a layer of authenticity to the narrative, making it a standout work in its genre.", 7, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3724) },
                    { 8, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3725), "Kudos to the author for creating such a captivating story. This book is a testament to their storytelling prowess, and I eagerly await their future works.", 8, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3725) },
                    { 9, "0efd01de-4eec-45ff-9de4-f03f9abdf104", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3726), "The beautifully crafted prose and engaging narrative of this book make it a standout in contemporary literature. I recommend it to fellow readers who appreciate a well-told tale.", 9, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3726) },
                    { 10, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3727), "An enthralling read that seamlessly blends elements of mystery and suspense. This book kept me on the edge of my seat, and I'm eager to explore more works by this talented author.", 10, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3728) },
                    { 11, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3728), "I thoroughly enjoyed the immersive world created by the author in this book. The descriptive prose and well-defined characters added depth to the narrative, making it a standout read.", 11, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3729) },
                    { 12, "0efd01de-4eec-45ff-9de4-f03f9abdf104", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3729), "This book offers a fresh perspective on a familiar genre. The author's innovative approach and storytelling techniques make it a compelling addition to my collection. Highly recommended!", 12, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3730) },
                    { 13, "122ee49a-1c09-45ba-a6a5-4e94b3be7c85", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3730), "A captivating journey through the pages of this book. The author's ability to create a vivid and atmospheric setting enhances the overall reading experience. A must-read for those who appreciate literary craftsmanship.", 13, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3731) },
                    { 14, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3731), "I was pleasantly surprised by the unique plot twists in this book. The author's storytelling prowess shines through, keeping readers engaged until the final chapter. An enjoyable read that deserves a spot on every bookshelf.", 14, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3732) },
                    { 15, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3732), "This book is a gem in contemporary literature. The author's exploration of complex themes and relatable characters resonated with me on a profound level. An enriching read that I'll cherish for years to come.", 15, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3733) }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "Image", "IsMain", "ProductId", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3587), "product-1.webp", true, 1, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3587) },
                    { 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3589), "product-2.webp", false, 1, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3589) },
                    { 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3590), "product-2.webp", true, 2, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3590) },
                    { 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3591), "product-3.webp", false, 2, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3591) },
                    { 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3592), "product-3.webp", true, 3, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3592) },
                    { 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3593), "product-4.webp", false, 3, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3593) },
                    { 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3594), "product-4.webp", true, 4, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3594) },
                    { 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3595), "product-5.webp", false, 4, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3595) },
                    { 9, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3596), "product-5.webp", true, 5, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3596) },
                    { 10, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3597), "product-6.webp", false, 5, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3598) },
                    { 11, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3598), "product-6.webp", true, 6, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3599) },
                    { 12, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3599), "product-7.webp", false, 6, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3600) },
                    { 13, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3600), "product-7.webp", true, 7, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3601) },
                    { 14, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3601), "product-8.webp", false, 7, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3602) },
                    { 15, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3602), "product-8.webp", true, 8, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3603) },
                    { 16, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3604), "product-9.webp", false, 8, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3604) },
                    { 17, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3605), "product-9.webp", true, 9, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3605) },
                    { 18, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3606), "product-10.webp", false, 9, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3606) },
                    { 19, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3607), "product-10.webp", true, 10, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3607) },
                    { 20, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3608), "product-11.webp", false, 10, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3608) },
                    { 21, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3609), "product-11.webp", true, 11, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3609) },
                    { 22, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3610), "product-12.webp", false, 11, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3610) },
                    { 23, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3611), "product-12.webp", true, 12, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3611) },
                    { 24, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3612), "product-1.webp", false, 12, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3612) },
                    { 25, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3613), "product-3.webp", true, 13, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3613) },
                    { 26, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3614), "product-5.webp", false, 13, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3615) },
                    { 27, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3615), "product-7.webp", true, 14, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3616) }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreatedDate", "Image", "IsMain", "ProductId", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 28, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3616), "product-4.webp", false, 14, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3617) },
                    { 29, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3617), "product-6.webp", true, 15, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3618) },
                    { 30, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3618), "product-4.webp", false, 15, false, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3619) }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "Id", "CreatedDate", "ProductId", "SoftDeleted", "TagId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3630), 1, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3630) },
                    { 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3631), 1, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3631) },
                    { 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3632), 1, false, 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3633) },
                    { 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3656), 1, false, 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3656) },
                    { 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3657), 2, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3657) },
                    { 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3658), 2, false, 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3658) },
                    { 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3659), 2, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3659) },
                    { 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3660), 2, false, 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3660) },
                    { 9, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3661), 3, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3661) },
                    { 10, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3661), 3, false, 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3662) },
                    { 11, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3662), 3, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3663) },
                    { 12, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3663), 3, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3664) },
                    { 13, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3664), 4, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3665) },
                    { 14, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3665), 4, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3666) },
                    { 15, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3666), 4, false, 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3667) },
                    { 16, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3667), 5, false, 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3668) },
                    { 17, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3668), 5, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3668) },
                    { 18, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3669), 5, false, 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3669) },
                    { 19, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3670), 6, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3670) },
                    { 20, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3671), 6, false, 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3671) },
                    { 21, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3672), 6, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3672) },
                    { 22, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3673), 7, false, 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3673) },
                    { 23, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3674), 7, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3674) },
                    { 24, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3675), 7, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3675) },
                    { 25, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3676), 8, false, 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3676) },
                    { 26, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3677), 8, false, 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3677) },
                    { 27, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3678), 8, false, 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3678) },
                    { 28, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3679), 8, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3679) },
                    { 29, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3680), 9, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3680) },
                    { 30, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3681), 9, false, 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3681) },
                    { 31, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3682), 9, false, 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3682) },
                    { 32, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3682), 9, false, 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3683) },
                    { 33, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3683), 10, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3684) },
                    { 34, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3684), 10, false, 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3685) },
                    { 35, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3685), 10, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3686) },
                    { 36, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3686), 10, false, 7, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3687) },
                    { 37, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3687), 11, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3688) },
                    { 38, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3688), 11, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3689) },
                    { 39, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3689), 11, false, 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3690) }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "Id", "CreatedDate", "ProductId", "SoftDeleted", "TagId", "UpdatedDate" },
                values: new object[,]
                {
                    { 40, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3690), 12, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3691) },
                    { 41, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3691), 12, false, 4, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3692) },
                    { 42, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3692), 12, false, 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3693) },
                    { 43, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3693), 13, false, 1, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3694) },
                    { 44, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3694), 13, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3695) },
                    { 45, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3695), 13, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3696) },
                    { 46, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3696), 14, false, 2, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3697) },
                    { 47, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3697), 14, false, 6, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3697) },
                    { 48, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3698), 14, false, 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3698) },
                    { 49, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3699), 15, false, 3, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3699) },
                    { 50, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3700), 15, false, 5, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3700) },
                    { 51, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3701), 15, false, 8, new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3701) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_AppUserId",
                table: "ProductComments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComments_ProductId",
                table: "ProductComments",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AuthorId",
                table: "Products",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DiscountId",
                table: "Products",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_ProductId",
                table: "ProductTags",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductComments");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7148), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7150), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7150) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7151), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7153), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7153) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7154), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7337), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7337) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7339), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7341), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7341) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7342), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7342) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7343), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7344), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7346) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7347), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7348), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7349) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7349), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7536), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7538), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7539) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7540), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7542), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7542) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7543), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7545), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7545) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7547) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7547), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7548) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7549), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7549) });

            migrationBuilder.UpdateData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7550), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7551) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7395), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7396) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7398), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7399), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7400) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7401), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7402) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7403), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7403) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7404), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7405), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7406) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7407), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7408), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7410), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7410) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7411), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7413), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7413) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7414), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7415), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7416) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7417), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7417) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7418), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7420), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7420) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7422) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7423), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7424), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7425) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7470), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7472), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7473), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7474) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7475), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7475) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7476), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7477), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7478) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7479), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7479) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7480), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7481), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7482) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7482), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7483) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7484), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7484) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7485), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7485) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7486), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7487) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7487), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7488) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7489), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7489) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7490), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7490) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7491), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7492) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7492), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7493) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7494), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7494) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7495), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7496) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7496), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7497) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7498), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7498) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7499), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7500) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7500), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7502), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7502) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7503), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7505) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7505), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7506) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7507), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7507) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7508), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7509) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7509), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7510) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7511), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7511) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7512), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7514), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7514) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7515), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7515) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7516), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7370));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7372));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7375));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7377));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7168), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7169) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7171), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7172), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7174), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7175), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7176), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7282), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7129), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7133), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7135) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7192), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7194), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7195) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7195), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7196) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7197), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7199), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7199) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7200), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7201), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7202) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7203), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7203) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7204), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(6979), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(6992), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7218), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7220), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7221), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7222) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7223), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7268), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7270), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7270) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7316), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7316) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7317), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7318) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7319), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7321), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7321) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7322), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7322) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7323), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7324), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7326), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7326) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7296), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7296) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7298), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7298) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7299), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7300) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7301), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7301) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7302), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7303), new DateTime(2024, 1, 18, 19, 34, 42, 99, DateTimeKind.Local).AddTicks(7304) });
        }
    }
}
