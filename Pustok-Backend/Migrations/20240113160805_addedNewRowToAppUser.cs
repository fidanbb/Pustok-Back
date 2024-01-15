using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class addedNewRowToAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8194), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8195) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8196), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8196) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8197), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8198) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8200), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8201) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8202), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8202) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8217), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8219), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8221), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8221) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8222), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8223) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8223), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8225), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8225) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8300), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8301) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8139), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8140) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8142), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8144), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8146), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8239), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8241), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8242) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8243), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8244), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8246), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8247), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8247) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8248), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8250), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8251) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8252), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8252) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(7985), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8001), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8267), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8267) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8269), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8270), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8272), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8288), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8290), new DateTime(2024, 1, 11, 23, 16, 19, 703, DateTimeKind.Local).AddTicks(8290) });
        }
    }
}
