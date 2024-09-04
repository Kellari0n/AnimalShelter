using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "ArrivalDate", "IsAdopted" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3629), true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "ArrivalDate", "IsAdopted" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3643), true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "ArrivalDate", "IsAdopted" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3646), true });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 4,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 5,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3650));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 6,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 7,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3656));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 10,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 11,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3659));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "ArrivalDate", "IsAdopted" },
                values: new object[] { null, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8706), false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "ArrivalDate", "IsAdopted" },
                values: new object[] { null, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8710), false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "ArrivalDate", "IsAdopted" },
                values: new object[] { null, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8712), false });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 4,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8713));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 5,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8714));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 6,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 7,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 10,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 11,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8722));
        }
    }
}
