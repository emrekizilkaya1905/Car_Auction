using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newCar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3023), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(2971) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 28, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3032), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3036), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3041), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3039) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3045), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3044) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3049), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3048) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3053), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3057), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3062), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3061) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3066), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3072), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3076), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3080), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3084), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3089), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3145), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3150), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3154), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3158), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3162), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3161) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3166), "ba9bc95c-4c31-46e0-9055-86c577134674", new DateTime(2025, 5, 4, 2, 22, 2, 280, DateTimeKind.Local).AddTicks(3165) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 1,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9005), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 2,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 5, 28, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9016), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9013) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 3,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9021), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 4,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9026), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9024) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 5,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9030), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 6,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9035), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 7,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9039), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9038) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 8,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9044), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9043) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 9,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9050), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 10,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9054), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9053) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 11,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9059), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 12,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9063), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 13,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9067), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9066) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 14,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9072), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9071) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 15,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9077), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9076) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 16,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9081), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 17,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9086), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9085) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 18,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9091), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 19,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9099), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 20,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 7, 15, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9103), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "VehicleId",
                keyValue: 21,
                columns: new[] { "EndTime", "SellerId", "StartTime" },
                values: new object[] { new DateTime(2025, 6, 21, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9107), "a0f7d450-2823-4757-bd02-248ca71de618", new DateTime(2025, 5, 4, 1, 48, 34, 383, DateTimeKind.Local).AddTicks(9106) });
        }
    }
}
