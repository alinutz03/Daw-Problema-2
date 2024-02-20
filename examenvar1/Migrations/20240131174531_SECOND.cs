using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace examenvar1.Migrations
{
    /// <inheritdoc />
    public partial class SECOND : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Grupe_Grupa_StudentId",
                table: "Studenti");

            migrationBuilder.RenameColumn(
                name: "Grupa_StudentId",
                table: "Studenti",
                newName: "GrupaId");

            migrationBuilder.RenameIndex(
                name: "IX_Studenti_Grupa_StudentId",
                table: "Studenti",
                newName: "IX_Studenti_GrupaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Grupe_GrupaId",
                table: "Studenti",
                column: "GrupaId",
                principalTable: "Grupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Studenti_Grupe_GrupaId",
                table: "Studenti");

            migrationBuilder.RenameColumn(
                name: "GrupaId",
                table: "Studenti",
                newName: "Grupa_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_Studenti_GrupaId",
                table: "Studenti",
                newName: "IX_Studenti_Grupa_StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Studenti_Grupe_Grupa_StudentId",
                table: "Studenti",
                column: "Grupa_StudentId",
                principalTable: "Grupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
