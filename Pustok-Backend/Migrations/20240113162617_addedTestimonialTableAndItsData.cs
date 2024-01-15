using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedTestimonialTableAndItsData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Testimonials_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3915), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3917), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3917) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3918), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3918) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3919), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3919) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3920), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3921) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3930), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3931), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3931) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3932), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3932) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3933), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3933) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3934), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3935), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3984), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3984) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3899), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3899) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3901), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3901) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3902), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3903) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3903), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3904) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3944), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3944) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3946), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3947), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3948), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3949) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3950), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3951) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3951), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3952) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3952), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3953) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3953), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3954) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3954), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3955) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3754), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3765) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3769), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3964), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3964) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3965), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3965) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3966), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3967), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3968) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3976), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3976) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3977), new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3977) });

            migrationBuilder.InsertData(
                table: "Testimonials",
                columns: new[] { "Id", "AppUserId", "CreatedDate", "Review", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "0efd01de-4eec-45ff-9de4-f03f9abdf104", new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3992), " Discovered Pustok, a reader's paradise! Vast collection caters to every literary taste. User-friendly interface made browsing a delight. Quick shipping, excellent customer service – my go-to online bookstore.", false, new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3992) },
                    { 2, "122ee49a-1c09-45ba-a6a5-4e94b3be7c85", new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3994), "Explored numerous online bookstores, but this one stands out. Curated selection, easy navigation – a reader's haven. Intuitive layout, discover new titles effortlessly. Timely delivery, well-packaged books – highly recommended satisfaction!.", false, new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3994) },
                    { 3, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3995), "Exceeded expectations, Pustok website. Robust search functionality, find what I wanted easily. Seamless checkout process, orders arrive promptly. Attention to detail, quality service keeps me coming back for more literary treasures.", false, new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3996) },
                    { 4, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3996), "Can't say enough good things about Pustok! Vast array of genres, inclusion of hard-to-find titles. Aesthetically pleasing and highly functional design. Orders accurate, well-packaged, delivered on time – a gem in online book retail!", false, new DateTime(2024, 1, 13, 20, 26, 17, 489, DateTimeKind.Local).AddTicks(3997) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_AppUserId",
                table: "Testimonials",
                column: "AppUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4012), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4012) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4038), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4038) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4039), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4040) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4041), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4041) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4042), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4042) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4054), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4055), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4055) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4056), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4056) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4057), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4057) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4058), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4059), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4059) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4115), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3996), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3996) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3997), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3998) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3999), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4000), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4071), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4071) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4073), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4073) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4074), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4075) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4075), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4076) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4077), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4078), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4078) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4079), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4079) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4080), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4082), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4082) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3878), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3889) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3892), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4094), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4095), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4095) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4096), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4096) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4097), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4097) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4106), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4107) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4108), new DateTime(2024, 1, 13, 20, 8, 5, 439, DateTimeKind.Local).AddTicks(4108) });
        }
    }
}
