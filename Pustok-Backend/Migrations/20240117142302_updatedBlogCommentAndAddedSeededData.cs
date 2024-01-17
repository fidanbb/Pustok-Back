using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pustok_Backend.Migrations
{
    public partial class updatedBlogCommentAndAddedSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "BlogComments");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "BlogComments");

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6550) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6551), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6551) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6552), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6552) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6554), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Adverts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6555), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6556) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6667), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6668) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6669), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6669) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6670), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6670) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6671), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6671) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6672), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6673) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6673), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6674) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6674), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6675) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6675), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6676), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6676) });

            migrationBuilder.InsertData(
                table: "BlogComments",
                columns: new[] { "Id", "AppUserId", "BlogId", "CreatedDate", "Message", "SoftDeleted", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "0efd01de-4eec-45ff-9de4-f03f9abdf104", 1, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6818), "The book recommendations on this blog are like a treasure map for bibliophiles! 🗺️📚 Each review is a journey into a new literary world. I recently picked up a suggested novel, and it completely captivated me. Thanks for being my guide in the vast realm of books!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6819) },
                    { 2, "122ee49a-1c09-45ba-a6a5-4e94b3be7c85", 2, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6820), "This blog is my go-to source for discovering hidden gems in the book world. The recent post on Naoki Urasawa's latest work was spot-on! The storytelling is phenomenal, and the blog's insights added a new layer to my reading experience. Can't wait for the next recommendation!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6820) },
                    { 3, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", 3, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6821), "Kudos to the blog for introducing me to fantastic books I never thought I'd enjoy. The thoughtful reviews make it easy to step out of my comfort zone. I picked up one of the recommended titles, and it turned out to be a pleasant surprise. Keep broadening our literary horizons!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6822) },
                    { 4, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", 4, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6822), "I appreciate the diverse range of books covered on this blog. The variety in genres and themes keeps my reading list exciting and unpredictable. The recent review on No Longer Human was enlightening. It's evident that the blogger has a genuine passion for literature. Bravo!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6823) },
                    { 5, "0efd01de-4eec-45ff-9de4-f03f9abdf104", 5, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6846), "I've been following this blog for months, and it never disappoints. The reviews are like a sneak peek into the soul of each book. The latest post on Jack London's novel left me eager to explore more of their work. Thanks for consistently providing such enriching content!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6846) },
                    { 6, "122ee49a-1c09-45ba-a6a5-4e94b3be7c85", 6, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6847), "The blog's reviews are like a beacon guiding me to the most intriguing plots and characters. I enjoyed the recent discussion on Romance. The analysis was thought-provoking and added a new layer of appreciation for the books in that category. An intellectual oasis for bookworms!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6847) },
                    { 7, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", 7, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6848), "This blog is a haven for those seeking literary escapades. The recent post on Fourth Wing resonated with me deeply. The emotional nuances explored in the review mirrored my own experience with the book. It's wonderful to find a community that shares the love for storytelling.", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6849) },
                    { 8, "8dce53a3-4394-46c3-8ebd-dbb06801e22e", 8, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6849), "The book recommendations here are like a curated collection of literary wonders. I recently picked up a novel highlighted in a post, and it became an instant favorite. Thank you for helping me discover gems I might have overlooked otherwise. Looking forward to the next revelation!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6850) },
                    { 9, "0efd01de-4eec-45ff-9de4-f03f9abdf104", 9, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6850), "This blog has become my literary compass. The reviews not only provide insights into the books but also ignite interesting discussions in the comments section. It's a community where book lovers unite. The recent post on detective sparked engaging conversations. Cheers to a blog that fosters a love for reading!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6851) },
                    { 10, "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7", 10, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6851), "I'm constantly impressed by the range of genres covered on this blog. The recent spotlight on Madeline MIller's works was a delightful surprise. I've now added their entire bibliography to my to-be-read list. The blog consistently delivers exciting discoveries for avid readers. Much appreciated!", false, new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6852) }
                });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6737), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6739), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6740), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6741), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6742), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6743), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6744) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6745), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6746), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6747), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6747) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6748), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6749), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6750), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6751), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6752) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6752), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6753), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6754) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6754), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6755), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6756), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6757) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6757), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6758), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6759) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6771), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6773), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6774), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6775), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6776), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6776) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6777), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6778), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6778) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6779), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6780), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6781), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6782), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6783), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6784), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6785), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6786) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6786), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6787), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6788), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6789), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6790), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6791), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6792), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6792) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6793), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6794), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6795), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6796), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6796) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6797), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6798), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6799), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6799) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6800), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6801), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6802) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6802), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6803), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6804), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6805) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6805), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6806) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6727));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6566), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6566) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6568), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6569), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6570) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6570), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6571), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6572), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6573) });

            migrationBuilder.UpdateData(
                table: "ContactMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6626), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6626) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6536), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6536) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6537), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6538) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6538), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6539) });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6540), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6583), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6584) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6586), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6586) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6587), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6588), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6588) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6589), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6590), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6591) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6591), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6592) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6592), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6593) });

            migrationBuilder.UpdateData(
                table: "Settings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6593), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6393) });

            migrationBuilder.UpdateData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6398), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6398) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6603), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6604) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6605), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6606), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6606) });

            migrationBuilder.UpdateData(
                table: "Socials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6607), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6607) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6616), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Subscribes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6617), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6618) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6649), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6650) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6650), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6651) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6652), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6652) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6653), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6653) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6654), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6654) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6655), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6655) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6656) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6656), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6657) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6635), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6636) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6637), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6637) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6638), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6638) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6639), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6639) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6640), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6640) });

            migrationBuilder.UpdateData(
                table: "Testimonials",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6641), new DateTime(2024, 1, 17, 18, 23, 1, 339, DateTimeKind.Local).AddTicks(6641) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BlogComments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "BlogComments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "BlogComments",
                type: "nvarchar(max)",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8623), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8623) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8625), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8626) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8627), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8628) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8628), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8629) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8630), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8631), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8632) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8633), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8634) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8635), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8636) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8636), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "BlogAuthors",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8638), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8638) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8729), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8729) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8731), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8733), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8735), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8736) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8737), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8739), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8744), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8746), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8747) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8748), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8750), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8752), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8753), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8754) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8755), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8757), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8757) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8759), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8760), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8762), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8763) });

            migrationBuilder.UpdateData(
                table: "BlogImages",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8764), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8782), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8784), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8786), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8787), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8788) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8789), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8790), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8791) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8792), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8793), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8795) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8796), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8797) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8798), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8799), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8801), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8802), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8804), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8804) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8805), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8807), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8807) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8808), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8810), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8811), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8812) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8813), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8814) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8815), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8816), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8818), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8819), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8821), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8822), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8823) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8825), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8827), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8828) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8829), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8830), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8831) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8832), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8833), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8835), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8836) });

            migrationBuilder.UpdateData(
                table: "BlogTags",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8836), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 4,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 5,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 6,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8705));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 7,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 8,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 9,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 10,
                column: "UpdatedDate",
                value: new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8714));

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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8595), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8596) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8597), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8599), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8599) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8600), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8602), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8603), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8605), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8605) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8606), new DateTime(2024, 1, 15, 19, 3, 45, 20, DateTimeKind.Local).AddTicks(8607) });

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
        }
    }
}
