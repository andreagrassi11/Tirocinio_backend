using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class sdafsadfehs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Show_FK_ShowId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_FK_ShowId",
                table: "Question");

            migrationBuilder.RenameColumn(
                name: "FK_ShowId",
                table: "Question",
                newName: "FK_Show");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FK_Show",
                table: "Question",
                newName: "FK_ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_FK_ShowId",
                table: "Question",
                column: "FK_ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Show_FK_ShowId",
                table: "Question",
                column: "FK_ShowId",
                principalTable: "Show",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
