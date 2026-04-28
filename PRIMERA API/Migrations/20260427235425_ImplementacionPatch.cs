using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRIMERA_API.Migrations
{
    /// <inheritdoc />
    public partial class ImplementacionPatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cantidad",
                table: "tabla1",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "tabla1",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "tabla1",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Cantidad", "Descripcion" },
                values: new object[] { 1, "Descripcion 1" });

            migrationBuilder.UpdateData(
                table: "tabla1",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Cantidad", "Descripcion" },
                values: new object[] { 2, "Descripcion 2" });

            migrationBuilder.UpdateData(
                table: "tabla1",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Cantidad", "Descripcion" },
                values: new object[] { 3, "Descripcion 3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cantidad",
                table: "tabla1");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "tabla1");
        }
    }
}
