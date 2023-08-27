using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TirocinioApi.Migrations.Api
{
    /// <inheritdoc />
    public partial class sdafdfsgndsfws : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Show");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Show");

            migrationBuilder.RenameColumn(
                name: "Venue",
                table: "Show",
                newName: "CoverImage");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CoverImage",
                table: "Show",
                newName: "Venue");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Show",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Show",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
