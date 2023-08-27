using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class Iwends : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_User_UserId",
                table: "Show");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Show",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Show_User_UserId",
                table: "Show",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Show_User_UserId",
                table: "Show");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Show",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddForeignKey(
                name: "FK_Show_User_UserId",
                table: "Show",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
