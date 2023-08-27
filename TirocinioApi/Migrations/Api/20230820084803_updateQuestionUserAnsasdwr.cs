using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class updateQuestionUserAnsasdwr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Question_QuestionId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_QuestionId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Result");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Result",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Result_QuestionId",
                table: "Result",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Question_QuestionId",
                table: "Result",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");
        }
    }
}
