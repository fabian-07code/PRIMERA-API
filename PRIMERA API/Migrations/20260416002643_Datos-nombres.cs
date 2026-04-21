using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRIMERA_API.Migrations
{
    /// <inheritdoc />
    public partial class Datosnombres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tabla1",
                columns: new[] { "Id", "Apellido", "Nombre" },
                values: new object[,]
                {
                    { 1, "Garcia", "Fabian" },
                    { 2, "Dominguez", "Paula" },
                    { 3, "Cruz", "Dilan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tabla1",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tabla1",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tabla1",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
