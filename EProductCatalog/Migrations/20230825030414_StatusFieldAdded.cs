using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EProductCatalog.Migrations
{
    /// <inheritdoc />
    public partial class StatusFieldAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "drinks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "drink_types",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "drinks");

            migrationBuilder.DropColumn(
                name: "status",
                table: "drink_types");
        }
    }
}
