using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class sdafss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_FK_QuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_FK_QuestionId",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "FK_QuestionId",
                table: "Answer",
                newName: "FK_Question");

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Answer",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Question_QuestionId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_QuestionId",
                table: "Answer");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "FK_Question",
                table: "Answer",
                newName: "FK_QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_FK_QuestionId",
                table: "Answer",
                column: "FK_QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Question_FK_QuestionId",
                table: "Answer",
                column: "FK_QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
