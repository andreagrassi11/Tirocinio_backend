using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class Inap : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "UserShow",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserShow_ResultId",
                table: "UserShow",
                column: "ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserShow_Result_ResultId",
                table: "UserShow",
                column: "ResultId",
                principalTable: "Result",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserShow_Result_ResultId",
                table: "UserShow");

            migrationBuilder.DropIndex(
                name: "IX_UserShow_ResultId",
                table: "UserShow");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "UserShow");
        }
    }
}
