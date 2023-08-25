using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EProductCatalog.Migrations
{
    /// <inheritdoc />
    public partial class FixDrinkType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drinks_drink_states_drink_state_id",
                table: "drinks");

            migrationBuilder.DropTable(
                name: "drink_states");

            migrationBuilder.RenameColumn(
                name: "drink_state_id",
                table: "drinks",
                newName: "drink_type_id");

            migrationBuilder.RenameIndex(
                name: "IX_drinks_drink_state_id",
                table: "drinks",
                newName: "IX_drinks_drink_type_id");

            migrationBuilder.CreateTable(
                name: "drink_types",
                columns: table => new
                {
                    drink_types_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drink_types", x => x.drink_types_id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_drinks_drink_types_drink_type_id",
                table: "drinks",
                column: "drink_type_id",
                principalTable: "drink_types",
                principalColumn: "drink_types_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_drinks_drink_types_drink_type_id",
                table: "drinks");

            migrationBuilder.DropTable(
                name: "drink_types");

            migrationBuilder.RenameColumn(
                name: "drink_type_id",
                table: "drinks",
                newName: "drink_state_id");

            migrationBuilder.RenameIndex(
                name: "IX_drinks_drink_type_id",
                table: "drinks",
                newName: "IX_drinks_drink_state_id");

            migrationBuilder.CreateTable(
                name: "drink_states",
                columns: table => new
                {
                    drink_states_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    updated_at = table.Column<DateTime>(type: "datetime2", nullable: false),
                    updated_by = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_drink_states", x => x.drink_states_id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_drinks_drink_states_drink_state_id",
                table: "drinks",
                column: "drink_state_id",
                principalTable: "drink_states",
                principalColumn: "drink_states_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
