using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETrade.Repository.Migrations
{
    public partial class SeedsData3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(3929));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4124));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4128));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 57, 143, DateTimeKind.Local).AddTicks(4130));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5400));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6006));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "ModelYear",
                value: new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6014));
        }
    }
}
