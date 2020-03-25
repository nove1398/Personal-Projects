using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blazor_Blog.Migrations
{
    public partial class updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 25, 15, 33, 48, 607, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 27, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 29, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2723));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 31, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 2, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 4, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 6, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 8, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 10, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 12, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 14, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 16, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 18, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 20, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 22, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2774));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 24, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 26, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 28, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2786));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 30, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 2, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 4, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 6, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 8, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2804));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 10, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 12, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 14, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 16, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2819));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 18, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 20, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2828));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 22, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 24, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2925));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 26, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2928));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 28, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 30, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 1, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 3, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 5, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 7, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 9, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2955));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 11, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 13, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2964));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 15, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 17, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 19, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 21, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 23, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 25, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 27, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 1, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 3, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 5, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 7, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3006));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 9, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 11, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 13, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 15, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 17, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 19, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 21, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 23, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 25, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 27, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 29, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 31, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 2, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3091));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 4, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 6, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 8, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 10, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 12, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 14, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 16, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 18, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 20, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 22, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 24, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 26, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3133));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 28, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 30, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 1, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3145));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 3, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 5, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 7, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 9, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 11, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 13, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 15, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 17, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3172));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 19, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3178));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 21, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 23, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 25, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 27, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 29, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 1, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 3, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 5, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 7, 15, 33, 48, 608, DateTimeKind.Local).AddTicks(3209));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Users");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 22, 18, 53, 5, 260, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 24, 18, 53, 5, 260, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 3, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 1, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 3, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 5, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 7, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 9, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 11, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 13, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 15, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 17, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 19, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 21, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 23, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 25, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 27, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 4, 29, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(75));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 1, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 3, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 5, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 7, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 9, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 11, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 13, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 15, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 17, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 19, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 21, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 23, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(157));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 25, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 27, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 29, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(169));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 5, 31, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(178));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 6, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 8, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 10, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 12, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 14, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(199));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 16, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(202));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 18, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(205));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 20, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 47,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 22, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(214));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 24, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(217));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 49,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 50,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(223));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 51,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 52,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 53,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 54,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 6, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 55,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 8, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 56,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 10, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 57,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 12, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(247));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 58,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 14, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 59,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 16, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 60,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 18, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 61,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 20, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 62,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 22, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 63,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 24, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 64,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 65,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 66,
                column: "CreatedAt",
                value: new DateTime(2020, 7, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 67,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 1, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(314));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 68,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 3, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 69,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 5, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 70,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 7, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 71,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 9, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 72,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 11, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 73,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 13, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(335));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 74,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 15, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 75,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 17, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 76,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 19, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 77,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 21, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(350));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 78,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 23, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 79,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 25, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 80,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 27, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 81,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 29, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 82,
                column: "CreatedAt",
                value: new DateTime(2020, 8, 31, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 83,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 84,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 85,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 6, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 86,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 8, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 87,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 10, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 88,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 12, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 89,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 14, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 90,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 16, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(395));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 91,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 18, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 92,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 20, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 93,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 22, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 94,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 24, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 95,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 26, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 96,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 28, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(416));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 97,
                column: "CreatedAt",
                value: new DateTime(2020, 9, 30, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 98,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 2, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 99,
                column: "CreatedAt",
                value: new DateTime(2020, 10, 4, 18, 53, 5, 261, DateTimeKind.Local).AddTicks(428));
        }
    }
}
