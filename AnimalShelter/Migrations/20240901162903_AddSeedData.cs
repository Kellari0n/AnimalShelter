using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_RefAnimalType_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Cages_Shelters_ShelterID",
                table: "Cages");

            migrationBuilder.RenameColumn(
                name: "OccupiedCapacity",
                table: "Cages",
                newName: "AnimalTypeID");

            migrationBuilder.RenameColumn(
                name: "AnimalTypeId",
                table: "Animals",
                newName: "AnimalTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals",
                newName: "IX_Animals_AnimalTypeID");

            migrationBuilder.AlterColumn<int>(
                name: "ShelterID",
                table: "Cages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "RefAnimalType",
                columns: new[] { "ID", "Type" },
                values: new object[,]
                {
                    { 1, "Dog" },
                    { 2, "Cat" },
                    { 3, "Bird" },
                    { 4, "Rabbit" },
                    { 5, "Hamster" },
                    { 6, "Reptile" },
                    { 7, "Fish" },
                    { 8, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Shelters",
                columns: new[] { "ID", "Location", "Name" },
                values: new object[] { 1, "", "" });

            migrationBuilder.InsertData(
                table: "Cages",
                columns: new[] { "ID", "AnimalTypeID", "CageNumber", "MaxCapacity", "ShelterID" },
                values: new object[,]
                {
                    { 1, 1, 101, 1, 1 },
                    { 2, 2, 102, 1, 1 },
                    { 3, 1, 201, 2, 1 },
                    { 4, 2, 202, 2, 1 },
                    { 5, 3, 301, 3, 1 },
                    { 6, 1, 401, 4, 1 },
                    { 7, 4, 501, 5, 1 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "ID", "AdoptionDate", "AnimalTypeID", "ArrivalDate", "Breed", "CageID", "IsAdopted", "Name", "PhotoUrl", "ShelterID" },
                values: new object[,]
                {
                    { 1, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8706), "Golden Retriever", 1, false, "Buddy", "buddy.jpg", null },
                    { 2, null, 2, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8710), "Siamese", 2, false, "Whiskers", "whiskers.jpg", null },
                    { 3, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8712), "Labrador", 3, false, "Max", "max.jpg", null },
                    { 4, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8713), "German Shepherd", 3, false, "Rex", "rex.jpg", null },
                    { 5, null, 2, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8714), "Maine Coon", 4, false, "Mittens", "mittens.jpg", null },
                    { 6, null, 3, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8716), "Canary", 5, false, "Tweety", "tweety.jpg", null },
                    { 7, null, 3, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8717), "Parrot", 5, false, "Sky", "sky.jpg", null },
                    { 8, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8719), "Beagle", 6, false, "Charlie", "charlie.jpg", null },
                    { 9, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8720), "Bulldog", 6, false, "Rocky", "rocky.jpg", null },
                    { 10, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8721), "Poodle", 6, false, "Bella", "bella.jpg", null },
                    { 11, null, 1, new DateTime(2024, 9, 1, 16, 29, 3, 230, DateTimeKind.Utc).AddTicks(8722), "Husky", 6, false, "Luna", "luna.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Adoptions",
                columns: new[] { "ID", "AdopterContact", "AdopterName", "AdoptionDate", "AdoptionFee", "AnimalID" },
                values: new object[,]
                {
                    { 1, "john322@email.em", "John Doe", new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 200.00m, 1 },
                    { 2, "@Sm1th22 - telegram", "Jane Smith", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150.00m, 2 },
                    { 3, "23476230123674 - phone", "Emily Johnson", new DateTime(2024, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 250.00m, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cages_AnimalTypeID",
                table: "Cages",
                column: "AnimalTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cages_CageNumber",
                table: "Cages",
                column: "CageNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_IsAdopted",
                table: "Animals",
                column: "IsAdopted");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_RefAnimalType_AnimalTypeID",
                table: "Animals",
                column: "AnimalTypeID",
                principalTable: "RefAnimalType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cages_RefAnimalType_AnimalTypeID",
                table: "Cages",
                column: "AnimalTypeID",
                principalTable: "RefAnimalType",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cages_Shelters_ShelterID",
                table: "Cages",
                column: "ShelterID",
                principalTable: "Shelters",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_RefAnimalType_AnimalTypeID",
                table: "Animals");

            migrationBuilder.DropForeignKey(
                name: "FK_Cages_RefAnimalType_AnimalTypeID",
                table: "Cages");

            migrationBuilder.DropForeignKey(
                name: "FK_Cages_Shelters_ShelterID",
                table: "Cages");

            migrationBuilder.DropIndex(
                name: "IX_Cages_AnimalTypeID",
                table: "Cages");

            migrationBuilder.DropIndex(
                name: "IX_Cages_CageNumber",
                table: "Cages");

            migrationBuilder.DropIndex(
                name: "IX_Animals_IsAdopted",
                table: "Animals");

            migrationBuilder.DeleteData(
                table: "Adoptions",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Adoptions",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Adoptions",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Animals",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cages",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RefAnimalType",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shelters",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "AnimalTypeID",
                table: "Cages",
                newName: "OccupiedCapacity");

            migrationBuilder.RenameColumn(
                name: "AnimalTypeID",
                table: "Animals",
                newName: "AnimalTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Animals_AnimalTypeID",
                table: "Animals",
                newName: "IX_Animals_AnimalTypeId");

            migrationBuilder.AlterColumn<int>(
                name: "ShelterID",
                table: "Cages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_RefAnimalType_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                principalTable: "RefAnimalType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cages_Shelters_ShelterID",
                table: "Cages",
                column: "ShelterID",
                principalTable: "Shelters",
                principalColumn: "ID");
        }
    }
}
