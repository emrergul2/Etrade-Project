using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ETrade.Repository.Migrations
{
    public partial class SeedsDataProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "Color", "ModelYear", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 5, 1, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5858), "Product-1", 1m },
                    { 2, 2, 3, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5863), "Product-2", 2m },
                    { 3, 3, 4, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(5999), "Product-3", 3m },
                    { 4, 7, 6, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6002), "Product-4", 4m },
                    { 5, 1, 6, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6004), "Product-5", 5m },
                    { 6, 4, 4, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6006), "Product-6", 6m },
                    { 7, 10, 3, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6008), "Product-7", 7m },
                    { 8, 9, 2, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6010), "Product-8", 8m },
                    { 9, 8, 3, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6012), "Product-9", 9m },
                    { 10, 6, 1, "-", new DateTime(2022, 6, 19, 0, 41, 30, 941, DateTimeKind.Local).AddTicks(6014), "Product-10", 10m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2022, 6, 19, 0, 40, 29, 789, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2022, 6, 19, 0, 40, 29, 789, DateTimeKind.Local).AddTicks(2920));
        }
    }
}
