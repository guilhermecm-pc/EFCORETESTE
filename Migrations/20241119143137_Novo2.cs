﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORETESTE.Migrations
{
    /// <inheritdoc />
    public partial class Novo2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorTotal",
                table: "reservade",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "reservade");
        }
    }
}
