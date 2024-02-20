using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examenvar1.Migrations
{
    /// <inheritdoc />
    public partial class SECOND2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdGrupa",
                table: "Studenti");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdGrupa",
                table: "Studenti",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
