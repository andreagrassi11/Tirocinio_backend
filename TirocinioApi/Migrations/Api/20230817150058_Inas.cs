using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class Inas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_IdentityUser_UserId",
                table: "Show");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUser",
                table: "IdentityUser");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "IdentityUser");

            migrationBuilder.RenameTable(
                name: "IdentityUser",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: false),
                    FKQuestionId = table.Column<int>(name: "FK_QuestionId", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answer_Question_FK_QuestionId",
                        column: x => x.FKQuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserShow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserShow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Result",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: false),
                    FKShowId = table.Column<int>(name: "FK_ShowId", type: "integer", nullable: false),
                    FKQuestionId = table.Column<int>(name: "FK_QuestionId", type: "integer", nullable: false),
                    FKUserShowId = table.Column<int>(name: "FK_UserShowId", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Result", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Result_Question_FK_QuestionId",
                        column: x => x.FKQuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_Show_FK_ShowId",
                        column: x => x.FKShowId,
                        principalTable: "Show",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Result_UserShow_FK_UserShowId",
                        column: x => x.FKUserShowId,
                        principalTable: "UserShow",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_FK_QuestionId",
                table: "Answer",
                column: "FK_QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_FK_QuestionId",
                table: "Result",
                column: "FK_QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_FK_ShowId",
                table: "Result",
                column: "FK_ShowId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_FK_UserShowId",
                table: "Result",
                column: "FK_UserShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Show_User_UserId",
                table: "Show",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_User_UserId",
                table: "Show");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Result");

            migrationBuilder.DropTable(
                name: "UserShow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "IdentityUser");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "IdentityUser",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUser",
                table: "IdentityUser",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Show_IdentityUser_UserId",
                table: "Show",
                column: "UserId",
                principalTable: "IdentityUser",
                principalColumn: "Id");
        }
    }
}
