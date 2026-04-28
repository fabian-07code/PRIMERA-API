using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PRIMERA_API.Migrations
{
    /// <inheritdoc />
    public partial class ImplementacionPatchTabla2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "tabla2",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "tabla2",
                keyColumn: "Id",
                keyValue: 1,
                column: "Descripcion",
                value: "Descripcion Rojo");

            migrationBuilder.UpdateData(
                table: "tabla2",
                keyColumn: "Id",
                keyValue: 2,
                column: "Descripcion",
                value: "Descripcion Verde");

            migrationBuilder.UpdateData(
                table: "tabla2",
                keyColumn: "Id",
                keyValue: 3,
                column: "Descripcion",
                value: "Descripcion Azul");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "tabla2");
        }
    }
}
