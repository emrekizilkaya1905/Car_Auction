using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PaymentHistoryConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ClientSecret",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentId",
                table: "PaymentHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2566), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 13, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2578), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2583), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2582) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2588), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2593), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2598), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2602), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2601) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2607), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2615), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2619), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2618) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2624), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2622) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2629), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2628) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2634), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2638), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2646), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2651), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2655), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2654) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2659), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2658) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2666), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2664) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 31, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2670), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2669) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 7, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2674), new DateTime(2025, 3, 20, 2, 17, 44, 126, DateTimeKind.Local).AddTicks(2673) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientSecret",
                table: "PaymentHistories");

            migrationBuilder.DropColumn(
                name: "StripePaymentId",
                table: "PaymentHistories");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4275), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 4, 11, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4283), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4337), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4341), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4340) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4344) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4350), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4349) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4354), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4358), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4357) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4362), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4361) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4366), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4365) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4370), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4369) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4373), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4372) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4377), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4376) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4385) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4390), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4389) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4394), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4398), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4402), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4401) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 29, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4407), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 5, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4411), new DateTime(2025, 3, 18, 4, 31, 43, 91, DateTimeKind.Local).AddTicks(4409) });
        }
    }
}
