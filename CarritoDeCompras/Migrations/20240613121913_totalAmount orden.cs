﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarritoDeCompras.Migrations
{
    /// <inheritdoc />
    public partial class totalAmountorden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Ordenes",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "Ordenes");
        }
    }
}
