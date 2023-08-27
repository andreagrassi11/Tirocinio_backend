using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class updasdshdsdffateQu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Result",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Result");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                columns: new[] { "IdShowRealized", "IdUserShow", "IdQuestionResult", "IdAnswerResult" });
        }
    }
}
