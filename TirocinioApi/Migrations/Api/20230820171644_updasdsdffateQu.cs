using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class updasdsdffateQu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Privacy",
                table: "UserShow",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Privacy",
                table: "UserShow");
        }
    }
}
