using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelter.Migrations
{
    /// <inheritdoc />
    public partial class AddRefAnimalType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnimalTypeId",
                table: "Animals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "RefAnimalType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefAnimalType", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_RefAnimalType_AnimalTypeId",
                table: "Animals",
                column: "AnimalTypeId",
                principalTable: "RefAnimalType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_RefAnimalType_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "RefAnimalType");

            migrationBuilder.DropIndex(
                name: "IX_Animals_AnimalTypeId",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "AnimalTypeId",
                table: "Animals");
        }
    }
}
