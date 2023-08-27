using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class updasdfateQu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionResultAnswer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.AddColumn<int>(
                name: "FK_ShowRealize",
                table: "UserShow",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdQuestionResult",
                table: "Result",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAnswerResult",
                table: "Result",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                columns: new[] { "IdShowRealized", "IdUserShow", "IdQuestionResult", "IdAnswerResult" });

            migrationBuilder.CreateTable(
                name: "AnswerResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    FKQuestionResult = table.Column<int>(name: "FK_QuestionResult", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerResult", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionResult",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    FKShowRealize = table.Column<int>(name: "FK_ShowRealize", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionResult", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerResult");

            migrationBuilder.DropTable(
                name: "QuestionResult");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "FK_ShowRealize",
                table: "UserShow");

            migrationBuilder.DropColumn(
                name: "IdQuestionResult",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "IdAnswerResult",
                table: "Result");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                columns: new[] { "IdShowRealized", "IdUserShow" });

            migrationBuilder.CreateTable(
                name: "QuestionResultAnswer",
                columns: table => new
                {
                    IdQuestionResultAnswer = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FKIdAnswer = table.Column<int>(name: "FK_IdAnswer", type: "integer", nullable: false),
                    FKIdQuestion = table.Column<int>(name: "FK_IdQuestion", type: "integer", nullable: false),
                    FKIdResult = table.Column<int>(name: "FK_IdResult", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionResultAnswer", x => x.IdQuestionResultAnswer);
                });
        }
    }
}
