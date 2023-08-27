using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class updasdshdsfdbds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Do",
                table: "ShowRealize",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Do",
                table: "ShowRealize");
        }
    }
}
