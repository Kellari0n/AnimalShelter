using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class InitCreateSqlite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefAnimalType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefAnimalType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Shelters",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Location = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shelters", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CageNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    OccupiedCapacity = table.Column<int>(type: "INTEGER", nullable: false),
                    ShelterID = table.Column<int>(type: "INTEGER", nullable: false),
                    AnimalTypeID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Cages_RefAnimalType_AnimalTypeID",
                        column: x => x.AnimalTypeID,
                        principalTable: "RefAnimalType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Cages_Shelters_ShelterID",
                        column: x => x.ShelterID,
                        principalTable: "Shelters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IncomeReports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalIncome = table.Column<decimal>(type: "TEXT", nullable: false),
                    ShelterID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_IncomeReports_Shelters_ShelterID",
                        column: x => x.ShelterID,
                        principalTable: "Shelters",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    AnimalTypeID = table.Column<int>(type: "INTEGER", nullable: false),
                    Breed = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    ArrivalDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdoptionDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    IsAdopted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CageID = table.Column<int>(type: "INTEGER", nullable: false),
                    ShelterID = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Animals_Cages_CageID",
                        column: x => x.CageID,
                        principalTable: "Cages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_RefAnimalType_AnimalTypeID",
                        column: x => x.AnimalTypeID,
                        principalTable: "RefAnimalType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animals_Shelters_ShelterID",
                        column: x => x.ShelterID,
                        principalTable: "Shelters",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Adoptions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnimalID = table.Column<int>(type: "INTEGER", nullable: false),
                    AdoptionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdoptionFee = table.Column<decimal>(type: "TEXT", nullable: false),
                    AdopterName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    AdopterContact = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adoptions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Adoptions_Animals_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                columns: new[] { "ID", "AnimalTypeID", "CageNumber", "MaxCapacity", "OccupiedCapacity", "ShelterID" },
                values: new object[,]
                {
                    { 1, 1, 101, 1, 0, 1 },
                    { 2, 2, 102, 1, 0, 1 },
                    { 3, 1, 201, 2, 1, 1 },
                    { 4, 2, 202, 2, 1, 1 },
                    { 5, 3, 301, 3, 2, 1 },
                    { 6, 1, 401, 4, 4, 1 },
                    { 7, 4, 501, 5, 0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "ID", "AdoptionDate", "AnimalTypeID", "ArrivalDate", "Breed", "CageID", "IsAdopted", "Name", "PhotoUrl", "ShelterID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 13, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1672), 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1668), "Golden Retriever", 1, true, "Buddy", "buddy.jpg", null },
                    { 2, new DateTime(2024, 11, 13, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1680), 2, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1679), "Siamese", 2, true, "Whiskers", "whiskers.jpg", null },
                    { 3, new DateTime(2024, 11, 13, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1683), 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1681), "Labrador", 3, true, "Max", "max.jpg", null },
                    { 4, null, 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1684), "German Shepherd", 3, false, "Rex", "rex.jpg", null },
                    { 5, null, 2, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1685), "Maine Coon", 4, false, "Mittens", "mittens.jpg", null },
                    { 6, null, 3, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1687), "Canary", 5, false, "Tweety", "tweety.jpg", null },
                    { 7, null, 3, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1688), "Parrot", 5, false, "Sky", "sky.jpg", null },
                    { 8, null, 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1690), "Beagle", 6, false, "Charlie", "charlie.jpg", null },
                    { 9, null, 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1691), "Bulldog", 6, false, "Rocky", "rocky.jpg", null },
                    { 10, null, 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1692), "Poodle", 6, false, "Bella", "bella.jpg", null },
                    { 11, null, 1, new DateTime(2024, 10, 30, 12, 11, 15, 3, DateTimeKind.Utc).AddTicks(1694), "Husky", 6, false, "Luna", "luna.jpg", null }
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
                name: "IX_Adoptions_AnimalID",
                table: "Adoptions",
                column: "AnimalID");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalTypeID",
                table: "Animals",
                column: "AnimalTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_CageID",
                table: "Animals",
                column: "CageID");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_IsAdopted",
                table: "Animals",
                column: "IsAdopted");

            migrationBuilder.CreateIndex(
                name: "IX_Animals_ShelterID",
                table: "Animals",
                column: "ShelterID");

            migrationBuilder.CreateIndex(
                name: "IX_Cages_AnimalTypeID",
                table: "Cages",
                column: "AnimalTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Cages_CageNumber",
                table: "Cages",
                column: "CageNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Cages_ShelterID",
                table: "Cages",
                column: "ShelterID");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeReports_ShelterID",
                table: "IncomeReports",
                column: "ShelterID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adoptions");

            migrationBuilder.DropTable(
                name: "IncomeReports");

            migrationBuilder.DropTable(
                name: "Animals");

            migrationBuilder.DropTable(
                name: "Cages");

            migrationBuilder.DropTable(
                name: "RefAnimalType");

            migrationBuilder.DropTable(
                name: "Shelters");
        }
    }
}
