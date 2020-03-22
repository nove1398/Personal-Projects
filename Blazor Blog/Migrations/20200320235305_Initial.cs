using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Blog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "FirstName", "LastName", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 3, 22, 18, 53, 5, 260, DateTimeKind.Local).AddTicks(981), "john1", "doe", "NameyNamey1" },
                    { 72, new DateTime(2020, 8, 11, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(332), "john72", "doe", "NameyNamey1" },
                    { 71, new DateTime(2020, 8, 9, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(329), "john71", "doe", "NameyNamey1" },
                    { 70, new DateTime(2020, 8, 7, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(323), "john70", "doe", "NameyNamey1" },
                    { 69, new DateTime(2020, 8, 5, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(320), "john69", "doe", "NameyNamey1" },
                    { 68, new DateTime(2020, 8, 3, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(317), "john68", "doe", "NameyNamey1" },
                    { 67, new DateTime(2020, 8, 1, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(314), "john67", "doe", "NameyNamey1" },
                    { 66, new DateTime(2020, 7, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(311), "john66", "doe", "NameyNamey1" },
                    { 65, new DateTime(2020, 7, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(305), "john65", "doe", "NameyNamey1" },
                    { 64, new DateTime(2020, 7, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(299), "john64", "doe", "NameyNamey1" },
                    { 63, new DateTime(2020, 7, 24, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(296), "john63", "doe", "NameyNamey1" },
                    { 62, new DateTime(2020, 7, 22, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(265), "john62", "doe", "NameyNamey1" },
                    { 61, new DateTime(2020, 7, 20, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(262), "john61", "doe", "NameyNamey1" },
                    { 60, new DateTime(2020, 7, 18, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(259), "john60", "doe", "NameyNamey1" },
                    { 59, new DateTime(2020, 7, 16, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(256), "john59", "doe", "NameyNamey1" },
                    { 58, new DateTime(2020, 7, 14, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(253), "john58", "doe", "NameyNamey1" },
                    { 57, new DateTime(2020, 7, 12, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(247), "john57", "doe", "NameyNamey1" },
                    { 56, new DateTime(2020, 7, 10, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(244), "john56", "doe", "NameyNamey1" },
                    { 55, new DateTime(2020, 7, 8, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(241), "john55", "doe", "NameyNamey1" },
                    { 54, new DateTime(2020, 7, 6, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(238), "john54", "doe", "NameyNamey1" },
                    { 53, new DateTime(2020, 7, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(235), "john53", "doe", "NameyNamey1" },
                    { 52, new DateTime(2020, 7, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(229), "john52", "doe", "NameyNamey1" },
                    { 73, new DateTime(2020, 8, 13, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(335), "john73", "doe", "NameyNamey1" },
                    { 51, new DateTime(2020, 6, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(226), "john51", "doe", "NameyNamey1" },
                    { 74, new DateTime(2020, 8, 15, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(338), "john74", "doe", "NameyNamey1" },
                    { 76, new DateTime(2020, 8, 19, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(344), "john76", "doe", "NameyNamey1" },
                    { 97, new DateTime(2020, 9, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(422), "john97", "doe", "NameyNamey1" },
                    { 96, new DateTime(2020, 9, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(416), "john96", "doe", "NameyNamey1" },
                    { 95, new DateTime(2020, 9, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(413), "john95", "doe", "NameyNamey1" },
                    { 94, new DateTime(2020, 9, 24, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(410), "john94", "doe", "NameyNamey1" },
                    { 93, new DateTime(2020, 9, 22, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(407), "john93", "doe", "NameyNamey1" },
                    { 92, new DateTime(2020, 9, 20, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(404), "john92", "doe", "NameyNamey1" },
                    { 91, new DateTime(2020, 9, 18, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(398), "john91", "doe", "NameyNamey1" },
                    { 90, new DateTime(2020, 9, 16, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(395), "john90", "doe", "NameyNamey1" },
                    { 89, new DateTime(2020, 9, 14, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(392), "john89", "doe", "NameyNamey1" },
                    { 88, new DateTime(2020, 9, 12, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(389), "john88", "doe", "NameyNamey1" },
                    { 87, new DateTime(2020, 9, 10, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(386), "john87", "doe", "NameyNamey1" },
                    { 86, new DateTime(2020, 9, 8, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(380), "john86", "doe", "NameyNamey1" },
                    { 85, new DateTime(2020, 9, 6, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(377), "john85", "doe", "NameyNamey1" },
                    { 84, new DateTime(2020, 9, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(374), "john84", "doe", "NameyNamey1" },
                    { 83, new DateTime(2020, 9, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(371), "john83", "doe", "NameyNamey1" },
                    { 82, new DateTime(2020, 8, 31, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(368), "john82", "doe", "NameyNamey1" },
                    { 81, new DateTime(2020, 8, 29, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(362), "john81", "doe", "NameyNamey1" },
                    { 80, new DateTime(2020, 8, 27, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(359), "john80", "doe", "NameyNamey1" },
                    { 79, new DateTime(2020, 8, 25, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(356), "john79", "doe", "NameyNamey1" },
                    { 78, new DateTime(2020, 8, 23, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(353), "john78", "doe", "NameyNamey1" },
                    { 77, new DateTime(2020, 8, 21, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(350), "john77", "doe", "NameyNamey1" },
                    { 75, new DateTime(2020, 8, 17, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(341), "john75", "doe", "NameyNamey1" },
                    { 98, new DateTime(2020, 10, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(425), "john98", "doe", "NameyNamey1" },
                    { 50, new DateTime(2020, 6, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(223), "john50", "doe", "NameyNamey1" },
                    { 48, new DateTime(2020, 6, 24, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(217), "john48", "doe", "NameyNamey1" },
                    { 22, new DateTime(2020, 5, 3, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(81), "john22", "doe", "NameyNamey1" },
                    { 21, new DateTime(2020, 5, 1, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(78), "john21", "doe", "NameyNamey1" },
                    { 20, new DateTime(2020, 4, 29, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(75), "john20", "doe", "NameyNamey1" },
                    { 19, new DateTime(2020, 4, 27, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(72), "john19", "doe", "NameyNamey1" },
                    { 18, new DateTime(2020, 4, 25, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(69), "john18", "doe", "NameyNamey1" },
                    { 17, new DateTime(2020, 4, 23, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(63), "john17", "doe", "NameyNamey1" },
                    { 16, new DateTime(2020, 4, 21, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(60), "john16", "doe", "NameyNamey1" },
                    { 15, new DateTime(2020, 4, 19, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(54), "john15", "doe", "NameyNamey1" },
                    { 14, new DateTime(2020, 4, 17, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(51), "john14", "doe", "NameyNamey1" },
                    { 13, new DateTime(2020, 4, 15, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(48), "john13", "doe", "NameyNamey1" },
                    { 12, new DateTime(2020, 4, 13, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(45), "john12", "doe", "NameyNamey1" },
                    { 11, new DateTime(2020, 4, 11, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(39), "john11", "doe", "NameyNamey1" },
                    { 10, new DateTime(2020, 4, 9, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(36), "john10", "doe", "NameyNamey1" },
                    { 9, new DateTime(2020, 4, 7, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(30), "john9", "doe", "NameyNamey1" },
                    { 8, new DateTime(2020, 4, 5, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(27), "john8", "doe", "NameyNamey1" },
                    { 7, new DateTime(2020, 4, 3, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(24), "john7", "doe", "NameyNamey1" },
                    { 6, new DateTime(2020, 4, 1, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(21), "john6", "doe", "NameyNamey1" },
                    { 5, new DateTime(2020, 3, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(12), "john5", "doe", "NameyNamey1" },
                    { 4, new DateTime(2020, 3, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(9), "john4", "doe", "NameyNamey1" },
                    { 3, new DateTime(2020, 3, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(6), "john3", "doe", "NameyNamey1" },
                    { 2, new DateTime(2020, 3, 24, 18, 53, 5, 260, DateTimeKind.Local).AddTicks(9982), "john2", "doe", "NameyNamey1" },
                    { 23, new DateTime(2020, 5, 5, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(124), "john23", "doe", "NameyNamey1" },
                    { 49, new DateTime(2020, 6, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(220), "john49", "doe", "NameyNamey1" },
                    { 24, new DateTime(2020, 5, 7, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(130), "john24", "doe", "NameyNamey1" },
                    { 26, new DateTime(2020, 5, 11, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(136), "john26", "doe", "NameyNamey1" },
                    { 47, new DateTime(2020, 6, 22, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(214), "john47", "doe", "NameyNamey1" },
                    { 46, new DateTime(2020, 6, 20, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(208), "john46", "doe", "NameyNamey1" },
                    { 45, new DateTime(2020, 6, 18, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(205), "john45", "doe", "NameyNamey1" },
                    { 44, new DateTime(2020, 6, 16, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(202), "john44", "doe", "NameyNamey1" },
                    { 43, new DateTime(2020, 6, 14, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(199), "john43", "doe", "NameyNamey1" },
                    { 42, new DateTime(2020, 6, 12, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(196), "john42", "doe", "NameyNamey1" },
                    { 41, new DateTime(2020, 6, 10, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(190), "john41", "doe", "NameyNamey1" },
                    { 40, new DateTime(2020, 6, 8, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(187), "john40", "doe", "NameyNamey1" },
                    { 39, new DateTime(2020, 6, 6, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(184), "john39", "doe", "NameyNamey1" },
                    { 38, new DateTime(2020, 6, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(181), "john38", "doe", "NameyNamey1" },
                    { 37, new DateTime(2020, 6, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(178), "john37", "doe", "NameyNamey1" },
                    { 36, new DateTime(2020, 5, 31, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(172), "john36", "doe", "NameyNamey1" },
                    { 35, new DateTime(2020, 5, 29, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(169), "john35", "doe", "NameyNamey1" },
                    { 34, new DateTime(2020, 5, 27, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(166), "john34", "doe", "NameyNamey1" },
                    { 33, new DateTime(2020, 5, 25, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(160), "john33", "doe", "NameyNamey1" },
                    { 32, new DateTime(2020, 5, 23, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(157), "john32", "doe", "NameyNamey1" },
                    { 31, new DateTime(2020, 5, 21, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(154), "john31", "doe", "NameyNamey1" },
                    { 30, new DateTime(2020, 5, 19, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(151), "john30", "doe", "NameyNamey1" },
                    { 29, new DateTime(2020, 5, 17, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(145), "john29", "doe", "NameyNamey1" },
                    { 28, new DateTime(2020, 5, 15, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(142), "john28", "doe", "NameyNamey1" },
                    { 27, new DateTime(2020, 5, 13, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(139), "john27", "doe", "NameyNamey1" },
                    { 25, new DateTime(2020, 5, 9, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(133), "john25", "doe", "NameyNamey1" },
                    { 99, new DateTime(2020, 10, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(428), "john99", "doe", "NameyNamey1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
