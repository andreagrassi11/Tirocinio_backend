using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class assdafssq : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Question_FK_QuestionId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Show_FK_ShowId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_UserShow_FK_UserShowId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_UserShow_Result_ResultId",
                table: "UserShow");

            migrationBuilder.DropIndex(
                name: "IX_UserShow_ResultId",
                table: "UserShow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_FK_QuestionId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_FK_ShowId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_FK_UserShowId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "ResultId",
                table: "UserShow");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "FK_QuestionId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Result");

            migrationBuilder.RenameColumn(
                name: "FK_UserShowId",
                table: "Result",
                newName: "IdUserShow");

            migrationBuilder.RenameColumn(
                name: "FK_ShowId",
                table: "Result",
                newName: "IdShowRealized");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "Result",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Result",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowId",
                table: "Result",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                columns: new[] { "IdShowRealized", "IdUserShow" });

            migrationBuilder.CreateIndex(
                name: "IX_Result_QuestionId",
                table: "Result",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Result_ShowId",
                table: "Result",
                column: "ShowId");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Question_QuestionId",
                table: "Result",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Show_ShowId",
                table: "Result",
                column: "ShowId",
                principalTable: "Show",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Result_Question_QuestionId",
                table: "Result");

            migrationBuilder.DropForeignKey(
                name: "FK_Result_Show_ShowId",
                table: "Result");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Result",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_QuestionId",
                table: "Result");

            migrationBuilder.DropIndex(
                name: "IX_Result_ShowId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "ShowId",
                table: "Result");

            migrationBuilder.RenameColumn(
                name: "IdUserShow",
                table: "Result",
                newName: "FK_UserShowId");

            migrationBuilder.RenameColumn(
                name: "IdShowRealized",
                table: "Result",
                newName: "FK_ShowId");

            migrationBuilder.AddColumn<int>(
                name: "ResultId",
                table: "UserShow",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Result",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "FK_QuestionId",
                table: "Result",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Result",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Result",
                table: "Result",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserShow_ResultId",
                table: "UserShow",
                column: "ResultId");

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
                name: "FK_Result_Question_FK_QuestionId",
                table: "Result",
                column: "FK_QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_Show_FK_ShowId",
                table: "Result",
                column: "FK_ShowId",
                principalTable: "Show",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Result_UserShow_FK_UserShowId",
                table: "Result",
                column: "FK_UserShowId",
                principalTable: "UserShow",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserShow_Result_ResultId",
                table: "UserShow",
                column: "ResultId",
                principalTable: "Result",
                principalColumn: "Id");
        }
    }
}
