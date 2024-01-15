using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedBlogRelatedTablesAndTheirDatas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogAuthors",
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
                    table.PrimaryKey("PK_BlogAuthors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogAuthorId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_BlogAuthors_BlogAuthorId",
                        column: x => x.BlogAuthorId,
                        principalTable: "BlogAuthors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BlogComments_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogImages_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogTags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogTags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogTags_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogTags_Tags_TagId",
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
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8438), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8440), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8441), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8442) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8444), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8445), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.InsertData(
                table: "BlogAuthors",
                columns: new[] { "Id", "CreatedDate", "FullName", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8623), "Alice Johnson", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8623) },
                    { 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8625), "Daniel Smith", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8626) },
                    { 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8627), "Emily Davis", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8628) },
                    { 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8628), "Michael Anderson", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8629) },
                    { 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8630), "Olivia Brown", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8631) },
                    { 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8631), "William Taylor", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8632) },
                    { 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8633), "Sophia White", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8634) },
                    { 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8635), "James Miller", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8636) },
                    { 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8636), "Ava Wilson", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8637) },
                    { 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8638), "Ethan Moore", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8638) }
                });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8463), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8465), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8466) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8467), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8468), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8469) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8469), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8470) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8471), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8558), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8416), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8419), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8421), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8421) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8423), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8423) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8489), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8490) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8491), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8495), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8497), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8498) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8499), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8501), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8501) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8502), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8503) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8205), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8224), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8522), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8524), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8524) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8526), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8526) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8527), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8541), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8542) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8543), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8544) });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedDate", "Name", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8595), "Fiction", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8596) },
                    { 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8597), "Non-Fiction", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8598) },
                    { 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8599), "Mystery", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8599) },
                    { 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8600), "History", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8601) },
                    { 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8602), "Fantasy", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8602) },
                    { 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8603), "Science Fiction", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8604) },
                    { 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8605), "Biography", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8605) },
                    { 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8606), "Self-Help", false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8607) }
                });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8571), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8572) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8574), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8575), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8577), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8579), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8581), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8581) });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "BlogAuthorId", "CreatedDate", "Description", "SoftDeleted", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on an extraordinary literary odyssey that transcends the boundaries of time and space. Join us as we delve deep into the profound realms of storytelling, where the power of words transforms into mesmerizing tales of wonder and introspection. From classic masterpieces to contemporary gems, this blog is a celebration of the magic that books bring into our lives, inviting readers to navigate worlds of boundless imagination and endless discovery.\r\n\r\n            The journey begins with the exploration of timeless classics that have stood the test of time, serving as pillars of literary achievement. Dive into the intricacies of character development, thematic richness, and the enduring relevance of stories that have captured the hearts of generations. Discover the nuances of narrative techniques and the artistry behind crafting immersive worlds that leave a lasting impact on the literary landscape.\r\n\r\n            As we traverse through the literary cosmos, we'll unravel the threads of storytelling that connect cultures, generations, and the shared human experience. Each blog post is an invitation to explore the intersections of literature and life, where stories become a mirror reflecting the diversity and complexity of the human condition.\r\n\r\n            Join us on this literary odyssey where words become vessels of imagination, emotion, and insight. Whether you're a seasoned bibliophile or a newcomer to the world of literature, there's something extraordinary waiting to be discovered in every chapter. Let the odyssey begin, and may the pages of your literary journey be filled with wonder, inspiration, and the joy of discovering the limitless possibilities of the written word.", false, "The Literary Odyssey: Navigating Worlds of Wonder", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8655) },
                    { 2, 2, new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "In the quiet corners of the imagination, stories come to life like whispers in the wind. Join us on a profound journey through the whispers of the imagination, where words weave tales of wonder, reflection, and captivating narratives. Explore the profound impact of books on our minds and the limitless realms they unveil, unraveling mysteries within each carefully chosen word.\r\n\r\n            This blog is an invitation to engage with the profound artistry of storytelling, where the echoes of imagination resonate through the ages. Immerse yourself in the exploration of literary techniques that give life to characters, evoke emotions, and transport readers to faraway lands. From character-driven sagas to plot-twisting mysteries, every genre becomes a gateway to new dimensions of understanding and appreciation.\r\n\r\n            Whispers of the Imagination seeks to unravel the layers of meaning embedded in the written word. It's not just about reading; it's about experiencing the magic of literature in its purest form. Join us in this exploration of literary craftsmanship, where every sentence is a brushstroke on the canvas of the reader's mind, creating vivid images and lasting impressions.\r\n\r\n            Through discussions on symbolism, narrative structure, and the evolving landscape of literature, this blog aims to deepen the connection between readers and the stories that shape our collective imagination. Let the whispers of the imagination guide you through the enchanting world of literature, where each book is a doorway to discovery.", false, "Whispers of the Imagination: Unraveling Mysteries Within Words", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8660) },
                    { 3, 3, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delve into the pages of history and savor the rich narratives that have shaped civilizations across time. This blog is a literary feast of the past, where every story becomes a portal to a bygone era. From ancient chronicles to modern historical epics, we invite you to discover the power of storytelling in preserving and transmitting the essence of our shared history.\r\n\r\n            Savoring the Pages of History is a journey through time, exploring the vivid tapestry of human experiences, triumphs, and challenges. Each blog post unfolds like a chapter in a grand historical novel, shedding light on events, personalities, and cultural shifts that have left an indelible mark on the world.\r\n\r\n            Join us in savoring the flavors of history, where the narrative becomes a banquet of knowledge and insight. From the rise and fall of empires to the untold stories of everyday heroes, this blog celebrates the diversity of historical literature. Engage with the complexities of historical interpretation, the art of storytelling, and the ongoing dialogue between the past and the present.\r\n\r\n            As we navigate the pages of history, let the stories resonate with you, providing not only a glimpse into the past but also a deeper understanding of the present. Savoring the Pages of History is an exploration of the written word as a time machine, inviting readers to partake in a literary feast that transcends the boundaries of time and enriches our understanding of the world.", false, "Savoring the Pages of History: A Literary Feast of the Past", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8663) },
                    { 4, 1, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Step into the shadowy realms of mystery as we unveil secrets, solve puzzles, and traverse the suspenseful landscapes of thrilling narratives. This blog is a journey into the unknown, where every twist and turn keeps readers on the edge of their seats. Join us in exploring the art of mystery writing and the timeless appeal of stories that captivate the mind, leaving a trail of intrigue and excitement in their wake.\r\n\r\n            Unveiling the Secrets of Mystery delves into the psychology of suspense, the intricacies of plot construction, and the art of crafting memorable characters in the mystery genre. From classic whodunits to psychological thrillers, every subgenre becomes a gateway to understanding the various facets of mystery literature.\r\n\r\n            Engage with discussions on detective fiction, crime thrillers, and the evolving nature of mystery narratives in contemporary literature. The blog seeks to unravel the secrets behind creating a compelling mystery, inviting readers to appreciate the craftsmanship of authors who keep them guessing until the final page.\r\n\r\n            Let the journey into the unknown begin, where every shadow conceals a clue, and every revelation opens new possibilities. Unveiling the Secrets of Mystery is not just a blog; it's an exploration of the enigmatic and a celebration of the enduring allure of mystery in the world of literature.", false, "Unveiling the Secrets of Mystery: Journey into the Unknown", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8701) },
                    { 5, 2, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on an enchanting journey through fantastical realms where dragons soar, wizards cast spells, and heroes rise. This blog is a magical portal to worlds where dreams take flight, and the boundaries of reality are stretched to their limits. Explore the wonders of fantasy literature, where imagination knows no bounds, and epic adventures unfold with every turn of the page.\r\n\r\n            Journeying Through Fantasy Realms is an invitation to explore the diverse landscapes of fantasy fiction, from high fantasy epics to urban fantasy adventures. Immerse yourself in discussions on world-building, mythical creatures, and the timeless themes that define the fantasy genre. Whether you're a seasoned fantasy enthusiast or a newcomer to the realms of magic and wonder, there's something captivating waiting to be discovered.\r\n\r\n            Engage with explorations of legendary quests, magical systems, and the enduring appeal of fantastical storytelling. The blog seeks to unravel the threads that connect fantasy literature with our deepest desires for adventure, heroism, and the extraordinary. Join us in this journey where every page turns into a gateway to realms where dreams take flight, and the impossible becomes a reality in the hands of visionary authors.\r\n\r\n            Let the magic of fantasy unfold before you, as we embark on a journey through realms where the boundaries between reality and imagination blur, and the fantastical becomes an integral part of the literary landscape.", false, "Journeying Through Fantasy Realms: Where Dreams Take Flight", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8703) },
                    { 6, 3, new DateTime(2021, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explore the nuanced landscapes of love and romance as portrayed through the written word. This blog is a celebration of the exquisite artistry found in tales of love and romance, where emotions unfold like a symphony of hearts. From timeless classics to contemporary tales, join us in a journey that delves into the complexities of human relationships, passion, and the enduring allure of stories that resonate with the deepest corners of the heart.\r\n\r\n            Love and Romance in Written Words seeks to unravel the intricacies of romantic literature, exploring the varying shades of love, heartbreak, and the transformative power of emotional connection. Engage with discussions on romantic archetypes, narrative tropes, and the evolving representation of love in literature across different cultures and time periods.\r\n\r\n            This blog is not merely about exploring love stories; it's an invitation to dissect the anatomy of romantic narratives, examining the elements that make them timeless and universally relatable. Join us in the exploration of love as a literary theme, where every novel becomes a unique note in the symphony of hearts that resonates across the pages of written words.\r\n\r\n            Whether you're a hopeless romantic or a curious reader intrigued by the complexities of human emotion, Love and Romance in Written Words promises a journey through literary landscapes where love unfolds in its many forms, leaving an indelible mark on the reader's heart.", false, "Love and Romance in Written Words: A Symphony of Hearts", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8705) },
                    { 7, 1, new DateTime(2022, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chart a course through the galaxies of science fiction literature. This blog is an invitation to explore tomorrow's frontiers, where futuristic worlds, advanced technologies, and thought-provoking speculations on the future of humanity come to life. Join us in unraveling the limitless possibilities that science fiction offers to the curious reader, charting a course through the cosmos of imagination and innovation.\r\n\r\n            Charting the Course of Science Fiction delves into the ever-evolving landscape of sci-fi literature, from classic space operas to speculative visions of the future. Engage with discussions on the intersection of science, technology, and storytelling, as we navigate the ethical dilemmas, utopian visions, and dystopian nightmares that define the genre.\r\n\r\n            The blog seeks to explore the influence of science fiction on societal perspectives, technological advancements, and the shaping of possible futures. Join us in contemplating the 'what if' scenarios, where authors envision worlds that challenge our understanding of reality and push the boundaries of human potential.\r\n\r\n            Whether you're a seasoned science fiction enthusiast or a newcomer to the genre, Charting the Course of Science Fiction promises an exploration of literary frontiers that expand the mind and spark the imagination. Let the journey through the galaxies of science fiction literature begin, where every novel becomes a star in the vast constellation of speculative storytelling.", false, "Charting the Course of Science Fiction: Exploring Tomorrow's Frontiers", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8707) },
                    { 8, 2, new DateTime(2020, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on intellectual voyages through the realms of non-fiction literature. This blog is a journey of illumination into real-world narratives that enlighten, challenge, and expand our understanding of the world. From thought-provoking essays to insightful biographies, we invite readers to delve into the vast landscape of non-fiction, where every page holds a treasure trove of knowledge waiting to be discovered.\r\n\r\n            Literary Explorations in Non-Fiction delves into the diverse realms of factual storytelling, from historical accounts to contemporary analyses of global issues. Engage with discussions on the impact of non-fiction literature on society, the role of the author as a guide through complex subjects, and the ethical considerations inherent in documenting real-world events.\r\n\r\n            The blog seeks to bridge the gap between the worlds of fiction and non-fiction, exploring the ways in which narrative techniques and storytelling conventions are employed to convey real-world truths. Join us in the exploration of literary explorations, where every non-fiction book becomes a window into the complexities, wonders, and challenges of the world we inhabit.\r\n\r\n            Whether you're passionate about history, social issues, or scientific discoveries, Literary Explorations in Non-Fiction promises a curated journey through the vast expanse of non-fiction literature, where every book is a beacon of knowledge waiting to be discovered and shared.", false, "Literary Explorations in Non-Fiction: Illuminating Real-World Narratives", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8709) },
                    { 9, 3, new DateTime(2021, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Celebrate the art of brevity and depth in the world of short stories. This blog is an exploration of the intricate craft of short-form fiction, where every word carries weight, and concise narratives unfold powerful emotions, vivid characters, and thought-provoking themes. Join us in appreciating the beauty of crafting emotional microcosms within the limited canvas of short stories, where the essence of storytelling is distilled into its purest form.\r\n\r\n            The Art of Short Stories delves into the profound impact of brevity, exploring how concise narratives have the power to evoke deep emotions, spark contemplation, and leave a lasting imprint on the reader's imagination. Engage with discussions on the art of pacing, character development, and thematic resonance within the unique structure of short stories.\r\n\r\n            This blog is not just an exploration of the short story as a literary form; it's an invitation to discover the diverse voices and styles that contribute to the richness of short-form fiction. Join us in celebrating the storytellers who masterfully navigate the delicate balance between conciseness and depth, creating emotional landscapes that linger in the minds of readers long after the final sentence.\r\n\r\n            Whether you're a seasoned admirer of short stories or a newcomer curious about the potential within brevity, The Art of Short Stories promises a curated journey through the captivating world of succinct narratives, where every story is a testament to the enduring power of concise and emotionally resonant storytelling.", false, "The Art of Short Stories: Crafting Emotional Microcosms", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8712) },
                    { 10, 1, new DateTime(2022, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Navigate the landscapes of self-discovery and personal growth through the lens of literature. This blog offers reflective insights into the wisdom embedded in self-help books, exploring the ways in which written words can guide, inspire, and empower individuals on their journey towards a fulfilling life.\r\n\r\n            In a world filled with challenges and complexities, the pursuit of personal development becomes a transformative journey. Each blog post is a thoughtful exploration of self-help literature, delving into the profound teachings and transformative narratives that have the potential to shape perspectives and ignite positive change.\r\n\r\n            Discover the power of mindset shifts, goal setting, and resilience through the lens of renowned self-help authors. From timeless classics to contemporary guides, this blog aims to curate a collection of insights that resonate with readers seeking inspiration, motivation, and practical strategies for personal and professional growth.\r\n\r\n            Through literary reflections, we will explore the intersection of literature and self-help, examining how the written word becomes a guiding light in moments of uncertainty and a source of strength during life's transitions. Whether you're embarking on a quest for mindfulness, resilience, or purpose, join us on this exploration of self-help literature as we navigate the path to personal growth together.\r\n\r\n            The journey unfolds with each turn of the page, offering readers a roadmap to self-discovery, empowerment, and a renewed sense of purpose. May these literary reflections serve as companions on your quest for a more meaningful and fulfilling life.", false, "Literary Reflections on Self-Help: Navigating the Path to Personal Growth", new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8714) }
                });

            migrationBuilder.InsertData(
                table: "BlogImages",
                columns: new[] { "Id", "BlogId", "CreatedDate", "Image", "IsMain", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8729), "blog-grid-1.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8729) },
                    { 2, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8731), "blog-grid-2.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8732) },
                    { 3, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8733), "blog-grid-2.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8734) },
                    { 4, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8735), "blog-grid-3.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8736) },
                    { 5, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8737), "blog-grid-3.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8738) },
                    { 6, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8739), "blog-grid-4.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8740) },
                    { 7, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8741), "blog-grid-4.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8741) },
                    { 8, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8743), "blog-grid-1.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8743) },
                    { 9, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8744), "blog-grid-2.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8745) },
                    { 10, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8746), "blog-grid-4.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8747) },
                    { 11, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8748), "blog-grid-1.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8749) },
                    { 12, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8750), "blog-grid-3.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8750) },
                    { 13, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8752), "blog-grid-3.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8752) },
                    { 14, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8753), "blog-grid-4.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8754) },
                    { 15, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8755), "blog-grid-4.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8756) },
                    { 16, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8757), "blog-grid-1.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8757) },
                    { 17, 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8759), "blog-grid-2.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8759) },
                    { 18, 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8760), "blog-grid-4.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8761) },
                    { 19, 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8762), "blog-grid-1.webp", true, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8763) },
                    { 20, 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8764), "blog-grid-3.webp", false, false, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8764) }
                });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "Id", "BlogId", "CreatedDate", "SoftDeleted", "TagId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8782), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8782) },
                    { 2, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8784), false, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8785) },
                    { 3, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8786), false, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8786) },
                    { 4, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8787), false, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8788) },
                    { 5, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8789), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8789) },
                    { 6, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8790), false, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8791) },
                    { 7, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8792), false, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8792) },
                    { 8, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8793), false, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8794) },
                    { 9, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8795), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8795) },
                    { 10, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8796), false, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8797) },
                    { 11, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8798), false, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8798) },
                    { 12, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8799), false, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8800) },
                    { 13, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8801), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8801) },
                    { 14, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8802), false, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8803) },
                    { 15, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8804), false, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8804) },
                    { 16, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8805), false, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8806) },
                    { 17, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8807), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8807) },
                    { 18, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8808), false, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8809) },
                    { 19, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8810), false, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8810) },
                    { 20, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8811), false, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8812) },
                    { 21, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8813), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8814) },
                    { 22, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8815), false, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8815) }
                });

            migrationBuilder.InsertData(
                table: "BlogTags",
                columns: new[] { "Id", "BlogId", "CreatedDate", "SoftDeleted", "TagId", "UpdatedDate" },
                values: new object[,]
                {
                    { 23, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8816), false, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8817) },
                    { 24, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8818), false, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8818) },
                    { 25, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8819), false, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8820) },
                    { 26, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8821), false, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8821) },
                    { 27, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8822), false, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8823) },
                    { 28, 8, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8824), false, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8825) },
                    { 29, 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8825), false, 1, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8826) },
                    { 30, 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8827), false, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8828) },
                    { 31, 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8829), false, 2, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8829) },
                    { 32, 9, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8830), false, 4, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8831) },
                    { 33, 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8832), false, 3, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8833) },
                    { 34, 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8833), false, 6, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8834) },
                    { 35, 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8835), false, 5, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8836) },
                    { 36, 10, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8836), false, 7, new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8837) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_AppUserId",
                table: "BlogComments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogId",
                table: "BlogComments",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogImages_BlogId",
                table: "BlogImages",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogAuthorId",
                table: "Blogs",
                column: "BlogAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_BlogId",
                table: "BlogTags",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogTags_TagId",
                table: "BlogTags",
                column: "TagId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "BlogImages");

            migrationBuilder.DropTable(
                name: "BlogTags");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "BlogAuthors");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9298), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9299) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9299), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9300), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9301) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9302), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9303), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9314), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9315), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9316), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9317), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9318) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9318), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9320), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9370), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9370) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9285), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9285) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9286), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9287) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9328), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9329) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9330), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9331), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9332), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9334), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9336), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9337), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9337) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9338), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9339), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9157), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9169), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9348), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9348) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9350), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9350) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9351), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9351) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9352), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9360), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9361), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9380), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9381) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9382), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9383), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9384), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9385), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9386), new DateTime(2024, 1, 13, 22, 7, 25, 411, DateTimeKind.Local).AddTicks(9386) });
        }
    }
}
