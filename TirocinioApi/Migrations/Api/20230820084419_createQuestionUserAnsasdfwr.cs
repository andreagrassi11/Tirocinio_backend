using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class createQuestionUserAnsasdfwr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionResultAnswer",
                columns: table => new
                {
                    IdQuestionResultAnswer = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FKIdQuestion = table.Column<int>(name: "FK_IdQuestion", type: "integer", nullable: false),
                    FKIdResult = table.Column<int>(name: "FK_IdResult", type: "integer", nullable: false),
                    FKIdAnswer = table.Column<int>(name: "FK_IdAnswer", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionResultAnswer", x => x.IdQuestionResultAnswer);
                });

            migrationBuilder.CreateTable(
                name: "ShowRealize",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Place = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FKShow = table.Column<int>(name: "FK_Show", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowRealize", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionResultAnswer");

            migrationBuilder.DropTable(
                name: "ShowRealize");
        }
    }
}
