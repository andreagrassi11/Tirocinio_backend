using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class updateQuestionUserAnsasdfwr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Show_ShowId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_ShowId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Result");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "Result",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Result_ShowId",
                table: "Result",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Show_ShowId",
                table: "Result",
                column: "ShowId",
                principalTable: "Show",
                principalColumn: "Id");
        }
    }
}
