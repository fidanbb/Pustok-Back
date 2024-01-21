using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class updatedProductCommentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Rate",
                table: "ProductComments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4778), 3, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4778) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4780), 2, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4780) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4781), 5, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4782) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4783), 4, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4783) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4784), 1, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4784) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4785), 1, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4786) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4787), 2, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4787) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4788), 3, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4788) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4789), 4, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4789) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4790), 5, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4791) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4791), 5, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4793), 4, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4793) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4794), 3, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4794) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4795), 3, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4796) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Rate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4796), 2, new DateTime(2024, 1, 21, 20, 46, 59, 827, DateTimeKind.Local).AddTicks(4797) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "ProductComments");

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

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3478), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3478) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3479), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3480), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3481), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3482) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3482), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3483), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3483) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3484), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3484) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3485), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3486), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3487), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3488) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3488), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3489) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3489), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3490) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3490), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3491), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3491) });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3492), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3492) });

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3462), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3463) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3464), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3465), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3465) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3466), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3467), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3468) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3468), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3241), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3242) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3527), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3529) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3530), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3531), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3533), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3533) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3535), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3536) });

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3537), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3538) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3717), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3718), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3719) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3720), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3720) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3721), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3721) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3722), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3722) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3723), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3723) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3724), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3724) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3725), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3725) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3726), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3726) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3727), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3728), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3729), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3730) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3730), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3731) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3731), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3732) });

            migrationBuilder.UpdateData(
                table: "ProductComments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3732), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3587), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3589), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3590), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3591), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3591) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3592), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3592) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3593), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3594), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3595), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3595) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3596), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3596) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3597), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3598), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3599) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3599), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3601) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3601), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3602) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3602), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3603) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3604), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3605), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3606), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3607), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3608), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3608) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3609), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3609) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3611), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3611) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3612), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3612) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3613), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3613) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3614), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3615) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3615), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3616) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3616), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3617) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3617), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3618) });

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3618), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3619) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3630), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3631), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3632), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3633) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3656), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3657), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3658), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3658) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3659), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3660), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3661), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3662), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3663), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3664), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3665), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3666), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3667), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3668), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3668) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3669), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3670), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3670) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3671), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3671) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3672), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3673), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3673) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3674), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3674) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3676), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3676) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3677), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3678), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3678) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3679), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3680), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3681), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3682), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3682) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3682), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3683), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3684), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3685), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3686) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3686), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3687), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3688) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3688), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3690), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3692) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3693), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3694) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3695) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3695), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3696) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3696), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3697), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3697) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3698), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3698) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3699), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3699) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3700), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3700) });

            migrationBuilder.UpdateData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3701), new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 19, 21, 34, 1, 836, DateTimeKind.Local).AddTicks(3576));

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
        }
    }
}
