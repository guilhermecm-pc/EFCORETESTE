using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCORETESTE.Migrations
{
    /// <inheritdoc />
    public partial class Novo1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "hospedes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(14)", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Datanascimento = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hospedes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reservade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hospedeId = table.Column<int>(type: "int", nullable: false),
                    quartoId = table.Column<int>(type: "int", nullable: false),
                    Datacheckin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Datacheckout = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_reservade_hospedes_hospedeId",
                        column: x => x.hospedeId,
                        principalTable: "hospedes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservade_quartos_quartoId",
                        column: x => x.quartoId,
                        principalTable: "quartos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_reservade_hospedeId",
                table: "reservade",
                column: "hospedeId");

            migrationBuilder.CreateIndex(
                name: "IX_reservade_quartoId",
                table: "reservade",
                column: "quartoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reservade");

            migrationBuilder.DropTable(
                name: "hospedes");
        }
    }
}
