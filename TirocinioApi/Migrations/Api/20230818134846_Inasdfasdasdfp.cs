using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class Inasdfasdasdfp : Migration
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
