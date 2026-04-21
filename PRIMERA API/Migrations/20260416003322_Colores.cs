using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PRIMERA_API.Migrations
{
    /// <inheritdoc />
    public partial class Colores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tabla2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Color = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tabla2", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "tabla2",
                columns: new[] { "Id", "Color" },
                values: new object[,]
                {
                    { 1, "Rojo" },
                    { 2, "Verde" },
                    { 3, "Azul" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tabla2");
        }
    }
}
