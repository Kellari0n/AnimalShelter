using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class FixCapacity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OccupiedCapacity",
                table: "Cages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "ArrivalDate" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6688), new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6685) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "ArrivalDate" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6697), new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6696) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "ArrivalDate" },
                values: new object[] { new DateTime(2024, 9, 17, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6700), new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 4,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 5,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 6,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 7,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 10,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 11,
                column: "ArrivalDate",
                value: new DateTime(2024, 9, 3, 14, 3, 29, 466, DateTimeKind.Utc).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 1,
                column: "OccupiedCapacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 2,
                column: "OccupiedCapacity",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 3,
                column: "OccupiedCapacity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 4,
                column: "OccupiedCapacity",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 5,
                column: "OccupiedCapacity",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 6,
                column: "OccupiedCapacity",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 7,
                column: "OccupiedCapacity",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OccupiedCapacity",
                table: "Cages");

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "AdoptionDate", "ArrivalDate" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3634), new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3629) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "AdoptionDate", "ArrivalDate" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3643) });

            migrationBuilder.UpdateData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "AdoptionDate", "ArrivalDate" },
                values: new object[] { new DateTime(2024, 9, 15, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 9, 1, 17, 12, 33, 350, DateTimeKind.Utc).AddTicks(3646) });

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
    }
}
